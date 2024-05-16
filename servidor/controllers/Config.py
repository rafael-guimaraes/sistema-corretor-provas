
from modelo.Banco import Banco as DB
from modelo.ImportCSV import ImportCSV as CSV
class Config:
    def __init__(self,database:DB) -> None:
        self._database = database
        pass

    def getConfigAlunos(self) -> dict:
        return self._database.getData("config",{"type":"translateAlunos"})[0]["data"]
    
        
    def importListFile(self,file_path):
        translator = self.getConfigAlunos()
        matricula = list(filter(lambda i: i[1] == "matricula",list(translator.items())))[0][0]
        print("Tradução matricula: "+ str(matricula))

        CSVManager = CSV(file_path,translator)
        payload = CSVManager.read()

        if payload["status"] == "success":
            result = self._database.insertData("alunos",payload["data"])
        else:
            return "Erro ao ler o arquivo:" + payload["content"]

        if result["acknowledged"]:
            return sorted(result["data"],key= lambda d: d["matricula"])
        else:
            return "Erro ao inserir no banco"
        

    def importAlunosFile(self,file_path):
        translator = self.getConfigAlunos()
        
        CSVManager = CSV(file_path,translator)
        payload = CSVManager.read()

        if payload["status"] == "success":
            result = self._database.insertData("alunos",payload["data"])
        else:
            return "Erro ao ler o arquivo:" + payload["content"]

        if result["acknowledged"]:
            return sorted(result["data"],key= lambda d: d["matricula"])
        else:
            return "Erro ao inserir no banco"
