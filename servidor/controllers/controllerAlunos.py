from modelo.banco import Banco as DB
from modelo.ImportCSV import ImportCSV as CSV
from setup.env import env
env = env()
        
def getAlunos(database:DB,filter:dict):
    return database.getData(env.COLLECTION_ALUNOS,filter)

def clearAlunos(database:DB):
    return database.deleteData(env.COLLECTION_ALUNOS)    

    

            


