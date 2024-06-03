from modelo.banco import Banco as DB
from modelo.ImportCSV import ImportCSV as CSV
from setup.env import env
env = env()
class Listas():
    def __init__(self,database:DB) -> None:
        self._database = database
        pass

        
    def getListas(self,filter={}):
        listas = self._database.getData(env.COLLECTION_LISTAS,filter)
        return listas
    
    def deleteListByID(self,id:str):
        if(len(id) > 0):
            deleted_item = self._database.deleteDataByID(env.COLLECTION_LISTAS,id)
            print(str(deleted_item))
            return f"{id} was succesfully deleted!" if deleted_item.acknowledged else f"{id} couldn't be deleted." 
        else:
            print("\n\n\n\n\nID NÃO SELECIONADO:"+id + "\n\n")
            return f"{id} is not an ID."
        


    def createListasTurmas(self):

        turmas = self._database.getData(env.COLLECTION_ALUNOS,{},distinct="turma")
        
        listas = []
        for turma in turmas:

            lista = {"title":turma,"type":"class"}

            alunos_turma = self._database.getData(env.COLLECTION_ALUNOS,{"turma":turma})

            matriculas = list(map(lambda a: a["matricula"],alunos_turma))
            lista["alunos"] = matriculas

            listas.append(lista)

        listas_criadas = self._database.insertData(env.COLLECTION_LISTAS,listas)
        if (listas_criadas["acknowledged"]):
            return listas
        else:
            return "Não foi possível criar as Turmas"
        
   