from modelo.gerador import Gerador

gerador = Gerador("../modelo.docx")
"/servidor/modelo/arquivos/cabecalho.docx"
dados = {
    "<turma>":"3H",
    "<professor>":"Alberson",
    "<titulo>":"Prova POO"
}
alunos = [{"matricula":50220326,"nome":"Gabriel Costa Fileno"},
                                                            {"matricula":50220384,"nome":"Kaio Eduardo Braga Barbosa"},
                                                            {"matricula":50220306,"nome":"Rafael Augusto Guimarães da Silva"}]

gerador.gerar_provas(dados, alunos, 2)