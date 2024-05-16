from modelo.Banco import Banco as DB
from modelo.ImportCSV import ImportCSV as CSV
class Alunos:
    def __init__(self,database:DB) -> None:
        self._database = database
        
    def getAlunos(self,filter:dict):
        return self._database.getData("Listas",filter)

    

    

            


