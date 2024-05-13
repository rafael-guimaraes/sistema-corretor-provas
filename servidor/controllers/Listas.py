from modelo.Banco import Banco as DB
class Listas:
    def __init__(self,database:DB,task:str,body:str) -> None:
        self._task = task
        self._body = body
        self._database = database
        pass

    def runTask(self):
        if self._task == "getListas":
            return self.getListas()
        
    def getListas(self,filter={}):
        return self._database.getData("listas",filter,distinct="lista")

            


