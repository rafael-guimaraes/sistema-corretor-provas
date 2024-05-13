from modelo.Banco import Banco as DB
class Listas:
    def __init__(self,database:DB,task:str,body:str) -> None:
        self._task = task
        self._body = body
        self._database = database
        pass

    def runTask(self):
        if self._task == "getListas":
            return self.getListas({})
        if self._task == "deleteListByID":
            return self.deleteListByID(self._body)
        
    def getListas(self,filter={}):
        listas = self._database.getData("listas",filter)
        return listas
    def deleteListByID(self,id:str):
        if(len(id) > 0):
            deleted_item = self._database.deleteDataByID("listas",id)
            print(str(deleted_item))
            return f"{id} was succesfully deleted!" if deleted_item.acknowledged else f"{id} couldn't be deleted." 
        else:
            print("\n\n\n\n\nID NÃO SELECIONADO:"+id + "\n\n")
            return f"{id} is not an ID."


            


