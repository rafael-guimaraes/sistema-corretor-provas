from modelo.gerador import Gerador
import os
from modelo.banco import Banco as DB

from setup.env import env

env = env()
def getProva(database:DB):
    alunos = database.getData(env.COLLECTION_PROVAS)
    return alunos

def createProva(database:DB, body):
    dados = body["dados"]
    
    prova = database.insertData(env.COLLECTION_PROVAS, {})
    id = prova["id"][0]
    id_lista = body["lista"]
    lista = database.getDataById(env.COLLECTION_LISTAS, id_lista)
    
    gerador = Gerador(body["arquivo"], dados, body["colunas"], id)
    
    
    alunos = lista["alunos"]
    titulo_lista = lista["title"]
    perguntas = gerador.ler_perguntas()
    
    nome = titulo_lista + " - " + dados["disciplina"] + " - " + dados["tipo"] + " - " + dados["bimestre"] + "bim"
    arquivo = os.path.realpath(env.STATIC + nome + ".pdf") 
    
    provas = gerador.criar_provas(alunos, perguntas)
    
    gerador.gerar_impressao(provas, arquivo)
  
    provas =  [{chave: valor for chave, valor in prova.items() if chave != 'documento'} for prova in provas]
    prova = { 
        "nome":nome,
        "lista": id_lista,
        "tipo": dados["tipo"],
        "bimestre": dados["bimestre"],
        "status": "corrigida",
        "arquivo": arquivo, 
        "provas": provas
    }

    prova = database.updateDataByID(env.COLLECTION_PROVAS, prova, id)
    
    return prova

def createExample(database, body):
    gerador = Gerador(body["arquivo"], body["dados"], body["colunas"], "")
    
    perguntas = gerador.ler_perguntas()
    exemplo = gerador.criar_exemplo(perguntas)
    
    return exemplo[0]

def corrigirProvas(database, body):
    pasta = body["pasta"]
    pasta = "C:\\Users\\rafae\\Desktop\\pasta_selecionada"