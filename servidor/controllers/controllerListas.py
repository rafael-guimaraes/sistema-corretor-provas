from modelo.banco import Banco as DB
from modelo.ImportCSV import ImportCSV as CSV
from setup.env import env
env = env()
        
def getListas(database:DB, filter={}):
    listas = database.getData(env.COLLECTION_LISTAS,filter)
    return listas
    
def deleteListByID(database:DB,id:str):
    if(len(id) > 0):
        deleted_item = database.deleteDataByID(env.COLLECTION_LISTAS,id)
        print(str(deleted_item))
        return f"{id} was succesfully deleted!" if deleted_item.acknowledged else f"{id} couldn't be deleted." 
    else:
        return f"{id} is not an ID."
        


def createListasTurmas(database:DB):

    turmas = database.getData(env.COLLECTION_ALUNOS,{},distinct="turma")
    
    listas = []
    for turma in turmas:


        alunos_turma = database.getData(env.COLLECTION_ALUNOS,{"turma":turma})

        lista = {"title":turma,"type":"class","alunos":alunos_turma}

        listas.append(lista)

    listas_criadas = database.insertData(env.COLLECTION_LISTAS,listas)
    if (listas_criadas["acknowledged"] == "True"):
        return listas
    else:
        return "Não foi possível criar as Turmas"
    
   