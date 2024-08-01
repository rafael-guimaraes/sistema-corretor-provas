from modelo.gerador import Gerador
from modelo.leitor import Leitor
import os
from modelo.banco import Banco as DB

from setup.env import env

env = env()
def getProva(database:DB):
    filter = { "$and": [ {"nome": {"$exists": True}},{"arquivo": {"$exists": True}} ] }
    alunos = database.getData(env.COLLECTION_PROVAS, filter)
    return alunos

async def createProva(socket_connection, database:DB, body):
    dados = body["dados"]
    
    prova = database.insertData(env.COLLECTION_PROVAS, {})
    id = prova["id"][0]
    id_lista = body["lista"]
    lista = database.getDataById(env.COLLECTION_LISTAS, id_lista)
    
    gerador = Gerador(socket_connection, body["arquivo"], dados, body["colunas"], id)
    
    
    alunos = lista["alunos"]
    titulo_lista = lista["title"]
    perguntas = gerador.ler_perguntas()
    
    nome = titulo_lista + " - " + dados["disciplina"] + " - " + dados["tipo"] + " - " + dados["bimestre"] + "bim"
    arquivo = os.path.realpath(env.STATIC + nome + ".pdf") 
    
    provas = await gerador.criar_provas(alunos, perguntas)
    
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

def createExample(socket_connection, database, body):
    gerador = Gerador(socket_connection, body["arquivo"], body["dados"], body["colunas"], "")
    
    perguntas = gerador.ler_perguntas()
    exemplo = gerador.criar_exemplo(perguntas)
    
    return exemplo[0]

def corrigirProvas(socket_connection, database, body):
    provas = Leitor(socket_connection).ler_provas(body["pasta"])
    for num, prova in enumerate(provas):
        print(f"Prova {num + 1}")
        print(prova.join(" "))