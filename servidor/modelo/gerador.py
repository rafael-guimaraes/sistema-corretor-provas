from docx import Document
from docx.enum.text import WD_ALIGN_PARAGRAPH
from docx.shared import Cm, Inches
from comtypes import client
from PyPDF2 import PdfMerger, PdfReader, PdfWriter
import traceback
import os
import base64

from modelo.prova import Prova


class Gerador():
    def __init__(self, arquivo): 
        self.arquivo = arquivo

    def criar_quebra(self):
        doc = Document()
        doc.add_page_break()
        
        return doc.element.body[0]
    
    def cabecalho(self):
        doc = Document("servidor/modelo/arquivos/cabecalho.docx")
        return doc.tables[0]
    
    def lista_de_chamada(self, alunos):
        doc = Document()

        for section in doc.sections:
            section.top_margin = Cm(1.27)
            section.bottom_margin = Cm(1.27)
            section.left_margin = Cm(1.27)
            section.right_margin = Cm(1.27)

        paragrafo = doc.add_paragraph('Lista de Chamada')
        paragrafo.alignment = WD_ALIGN_PARAGRAPH.CENTER
        fonte = paragrafo.style.font
        fonte.name = 'Arial'

        tabela = doc.add_table(rows=1, cols=3)
        tabela.style = 'Table Grid'

        larguras = [0.5, 10, 3] 
        for i, largura in enumerate(larguras):
            tabela.columns[i].width = Inches(largura)

      
        cabecalho = tabela.rows[0].cells
        cabecalho[0].text = 'Matrícula'
        cabecalho[1].text = 'Nome'
        cabecalho[2].text = 'Assinatura'

       
        for aluno in alunos:
            linha = tabela.add_row().cells
            linha[0].text = aluno['matricula']
            linha[1].text = aluno['nome']
            linha[2].text = ''

        return doc
    
    def processar_word(self):
        try:
            perguntas = []
            conteudo = ""
            doc = Document(self.arquivo)
            for num_tabela, tabela in enumerate(doc.tables):
                for linha in tabela.rows:
                    celula = linha.cells[0]
                    if num_tabela == 0:
                        conteudo = celula.text.replace("Conteúdo: ", "").strip()
                        break  
                    else:
                        enunciado = None
                        alternativas = []
                        for num_campo, campo in enumerate(celula.tables):
                            if num_campo == 0:
                                enunciado = campo.rows[0].cells[0]
                            else:
                                for alternativa in campo.rows:
                                    alternativas.append(alternativa.cells[0])
                        
                        perguntas.append({
                            "enunciado": enunciado,
                            "alternativas": alternativas,
                            "resposta": 0
                        })
            return perguntas, conteudo
        except Exception as e:
            print(e)
            return None, None

    def gerar_provas(self, dados, alunos, colunas):
        perguntas, dados['<conteudo>'] = self.processar_word()
        cabecalho = self.cabecalho()
        lista_provas = []

        for aluno in alunos:
            dados['<nome>'] = aluno['nome']
            dados['<matricula>'] = aluno['matricula']
            prova = Prova(self.arquivo, dados, perguntas, cabecalho, colunas).criar_prova()
            
            lista_provas.append({"matricula": aluno['matricula'], "situacao": "criada", "gabarito": prova[1], "documento": prova[0]})
        
        pdfs = self.gerar_pdfs(lista_provas)
        if len(pdfs) - len(lista_provas) == 0:
            for i in range(len(lista_provas)):
                lista_provas[i]['documento'] = pdfs[i]
            return lista_provas
        return []
    
    def gerar_exemplo(self, dados):
        perguntas, dados['<conteudo>'] = self.processar_word()
        cabecalho = cabecalho()
        dados['<nome>'] = 'Fulano da Silva Costa'
        dados['<matricula>'] = '50220000'
        prova = Prova(self.arquivo, dados, perguntas, cabecalho).criar_prova()
        return prova
    
    def ajustar_folhas(self, caminho):
        reader = PdfReader(caminho)
        if len(reader.pages) % 2 != 0:
            writer = PdfWriter()
            for page in reader.pages:
                writer.add_page(page)
            writer.add_blank_page()
            with open(caminho, 'wb') as output_pdf:
                writer.write(output_pdf)
    
    def gerar_pdfs(self, lista):
        pdfs = []
        word = client.CreateObject('Word.Application')
        try:
            for i, prova in enumerate(lista):
                prova['documento'].save(f"servidor/modelo/temp/{i}.docx")
                doc = word.Documents.Open(os.path.realpath(f"servidor/modelo/temp/{i}.docx"))
                doc.SaveAs(os.path.realpath(f"servidor/modelo/temp/{i}.pdf"), FileFormat=17)
                doc.Close()
                self.ajustar_folhas(f"servidor/modelo/temp/{i}.pdf")
                
                with open(f"servidor/modelo/temp/{i}.pdf", "rb") as pdf_file:
                    pdfs.append(base64.b64encode(pdf_file.read()))
        except Exception as e:
            traceback.print_exc()
            
        finally:
            word.Quit()
            for i in range(len(lista)):
                try:
                    os.remove(f"servidor/modelo/temp/{i}.docx")
                    os.remove(f"servidor/modelo/temp/{i}.pdf")
                except:
                    pass
        return pdfs
            
    def gerar_impressao(self, arquivo_saida, provas):
        word = client.CreateObject('Word.Application')
        merger = PdfMerger()
        try:
            for i, prova in enumerate(provas):
                prova[0].save(f"servidor/modelo/temp/{i}.docx")
                doc = word.Documents.Open(os.path.realpath(f"servidor/modelo/temp/{i}.docx"))
                doc.SaveAs(os.path.realpath(f"servidor/modelo/temp/{i}.pdf"), FileFormat=17)
                doc.Close()
                self.ajustar_folhas(f"servidor/modelo/temp/{i}.pdf")
                merger.append(f"servidor/modelo/temp/{i}.pdf") 
                
        except Exception as e:
            traceback.print_exc()
        finally:
            word.Quit()

        merger.write(os.path.realpath(arquivo_saida))
        merger.close()
        for i in range(len(provas)):
            os.remove(f"servidor/modelo/temp/{i}.docx")
            os.remove(f"servidor/modelo/temp/{i}.pdf")
      
      


