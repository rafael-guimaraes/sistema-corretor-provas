from modelo.Banco import Banco as DB
from modelo.ImportCSV import ImportCSV as CSV
from setup.env import env
env = env()
class Alunos:
    def __init__(self,database:DB) -> None:
        self._database = database
        
    def getAlunos(self,filter:dict):
        return self._database.getData(env.COLLECTION_ALUNOS,filter)

    def clearAlunos(self):
        return self._database.deleteData(env.COLLECTION_ALUNOS)    

    

            


