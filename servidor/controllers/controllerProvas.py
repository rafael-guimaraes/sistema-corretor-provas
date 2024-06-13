from modelo.gerador import Gerador
from modelo.banco import Banco as DB

from setup.env import env

env = env()
def getProva(database:DB):
    alunos = database.getData(env.COLLECTION_PROVAS)
    return alunos

def createProva(database:DB, body):
    dados = body["dados"]
    gerador = Gerador(body["arquivo"], dados, body["colunas"])
    
    id_lista = body["lista"]

    lista = database.getDataById(env.COLLECTION_LISTAS, id_lista)
    alunos = lista["alunos"]
    titulo_lista = lista["title"]
    perguntas = gerador.ler_perguntas()
   
    provas = gerador.criar_provas(alunos, perguntas)
    arquivo = gerador.gerar_impressao(provas)
    prova = { 
        "nome": titulo_lista + " - " + dados["disciplina"] + " - " + dados["tipo"] + " - " + dados["bimestre"] + "bim",
        "lista": id_lista,
        "tipo": dados["tipo"],
        "bimestre": dados["bimestre"],
        "status": "corrigida",
        "arquivo": arquivo, 
        "provas": provas
    }

    prova = database.insertData(env.COLLECTION_PROVAS, prova)
    
    return prova

def createExample(database, body):
    gerador = Gerador(body["arquivo"], body["dados"], body["colunas"])
    
    perguntas = gerador.ler_perguntas()
    exemplo = gerador.criar_exemplo(perguntas)
    
    return exemplo[0]