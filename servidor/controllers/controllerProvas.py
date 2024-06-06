from modelo.gerador import Gerador
from modelo.banco import Banco as DB

from setup.env import env

env = env()

def createProva(database:DB, body):
    gerador = Gerador(body["arquivo"], body["dados"], body["colunas"])
    
    id_lista = body["lista"]

    alunos = database.getDataById(env.COLLECTION_LISTAS, id_lista)["alunos"]
    perguntas = gerador.ler_perguntas()
   
    provas = gerador.criar_provas(alunos, perguntas)
    
    database.insertData('provas', provas)
    return provas

def createExample(database, body):
    print(body)
    print(body["colunas"])
    gerador = Gerador(body["arquivo"], body["dados"], body["colunas"])
    
    perguntas = gerador.ler_perguntas()
    exemplo = gerador.criar_exemplo(perguntas)
    
    return exemplo[0]