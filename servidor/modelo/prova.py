from docx import Document
from docx.oxml.table import CT_TcPr
from docx.oxml.text.paragraph import CT_P
from copy import deepcopy
from docx.shared import Cm, Pt
import random
from docx.oxml.ns import qn
from docx.oxml import parse_xml
from docx.oxml import OxmlElement
from PIL import Image

class Prova():
    def __init__(self, arquivo, dados, perguntas, cabecalho, colunas):
        self.arquivo = arquivo
        self.dados = dados
        self.perguntas = deepcopy(perguntas)
        self.cabecalho = deepcopy(cabecalho)
        self.gabarito = ""
        self.colunas = colunas
        self.alterar_cabecalho()
        

    def embaralhar_alternativas(self, lista, posicao):
        item = lista[posicao]
        random.shuffle(lista)
        nova_posicao = lista.index(item)
        return nova_posicao

    def embaralhar_perguntas(self, perguntas):
        for pergunta in perguntas:
            pergunta["resposta"] = self.embaralhar_alternativas(pergunta["alternativas"], pergunta["resposta"])
        random.shuffle(perguntas)
        
    def criar_sessao(self, num_colunas):
        sessao = OxmlElement("w:sectPr")
        
        layout = OxmlElement("w:type")
        layout.set(qn("w:val"), "continuous") 
        sessao.append(layout)
        
        colunas = OxmlElement("w:cols")
        colunas.set(qn("w:space"), "100")  
        colunas.set(qn("w:num"), str(num_colunas))
        sessao.append(colunas)
        
        margem = OxmlElement("w:pgMar")
        margem.set(qn("w:top"), "720")  
        margem.set(qn("w:right"), "720")  
        margem.set(qn("w:bottom"), "720")  
        margem.set(qn("w:left"), "720")  
        margem.set(qn("w:header"), "720")  
        margem.set(qn("w:footer"), "720")  
        margem.set(qn("w:gutter"), "0")  
        sessao.append(margem)
        
        tamanho = OxmlElement("w:pgSz")
        tamanho.set(qn("w:w"), "12240")  
        tamanho.set(qn("w:h"), "15840")  
        sessao.append(tamanho)
        
        return sessao
        
    def criar_run(self, texto, fonte, bold):
        doc = Document()
        para = doc.add_paragraph()
        run = para.add_run(texto)
        run.font.name = fonte
        run.font.bold = bold
        para._element.get_or_add_pPr().spacing_after = Pt(0)      
        para._element.get_or_add_pPr().spacing_before = Pt(0)
    
        return run._element   
    
    def alterar_cabecalho(self):
        for linha in self.cabecalho.rows:
            for celulas in linha.cells:
                for paragrafo in celulas.paragraphs:
                    for marcacao, valor in self.dados.items():
                        if marcacao in paragrafo.text:
                            print( marcacao + " " + str(valor))
                            paragrafo.text = paragrafo.text.replace(marcacao, str(valor))
        
        celulas_com_imagens = [
            (0, 0, 'servidor/modelo/arquivos/univap.png', 0.17),
            (0, 13, 'servidor/modelo/arquivos/fve.png', 0.17),
            (3, 1, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 2, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 3, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 4, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 5, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 6, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 7, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 8, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 9, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 10, 'servidor/modelo/arquivos/letras.png', 0.17),
            (3, 11, 'servidor/modelo/arquivos/letras.png', 0.17),
            (6, 13, 'servidor/modelo/arquivos/assinatura.png', 0.17),
            (7, 1, 'servidor/modelo/arquivos/observacoes.png', 0.17)
        ]
        for linha, coluna, imagem, escala in celulas_com_imagens:
            if linha < len(self.cabecalho.rows) and coluna < len(self.cabecalho.rows[linha].cells):
                cell = self.cabecalho.cell(linha, coluna)
                with Image.open(imagem) as img:
                    comprimento, altura = img.size

                comprimento = Cm((comprimento / 96) * escala)

                paragraph = cell.paragraphs[0] if cell.paragraphs else cell.add_paragraph()
                run = paragraph.add_run()
                run.font.name = 'Arial'
                run.font.size = Pt(2)
                run.add_picture(imagem, width=comprimento)
                
            
    def criar_prova(self):
        LETRAS = "abcde"
        self.embaralhar_perguntas(self.perguntas)
        
        novo_doc = Document(self.arquivo)    
        
        corpo = novo_doc.element.body
        corpo.clear()
        
        p = novo_doc.add_paragraph()._element
        propriedades = OxmlElement("w:pPr")
        propriedades.append(self.criar_sessao(1))
        p.insert(0, propriedades)

        corpo.insert(0, self.cabecalho._element)

        sessao = self.criar_sessao(self.colunas)
        
        for num_pergunta, pergunta in enumerate(self.perguntas): 
            marcado = False
            for elemento in pergunta['enunciado']._element.getchildren():
                if not isinstance(elemento, CT_TcPr): 
                    if isinstance(elemento, CT_P):
                        pPr = elemento.get_or_add_pPr()
                        pPr.spacing_before = Pt(6)
                        pPr.spacing_after = Pt(2)
                        
                        if not marcado:
                            numero = self.criar_run(f"{num_pergunta + 1}. ", "Arial", True)
                            elemento.insert(1, numero)
                            marcado = True
                    sessao.append(elemento)
            
            for num_alternativa, alternativa in enumerate(pergunta['alternativas']):
                marcado = False
                for elemento in alternativa._element.getchildren():
                    if not isinstance(elemento, CT_TcPr): 
                        if isinstance(elemento, CT_P):
                            pPr = elemento.get_or_add_pPr()
                            pPr.spacing_before = Pt(2)
                            pPr.spacing_after = Pt(2)
                            
                            if not marcado:
                                letra = self.criar_run(f"{LETRAS[num_alternativa]}) ", "Arial", True)
                                elemento.insert(1, letra)
                                marcado = True
                        sessao.append(elemento)
            self.gabarito += LETRAS[pergunta["resposta"]] 
        corpo.append(sessao)
        return novo_doc, self.gabarito

    
    