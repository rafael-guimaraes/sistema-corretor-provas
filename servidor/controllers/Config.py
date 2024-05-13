
from modelo.Banco import Banco as DB
from modelo.ImportCSV import ImportCSV as CSV
class Config:
    def __init__(self,database:DB, task:str,body:str) -> None:
        self._task = task
        self._body = body
        self._database = database
        pass

    def runTask(self):
        if self._task == "importAlunosFile":
            result = self.importAlunosFile()
            self.createListasTurmas()
            return result

    def getConfigAlunos(self):
        return self._database.getData("config",{"type":"translateAlunos"})[0]["data"]

    def insertAlunos(self,payload):
        return self._database.insertData("alunos",payload)
        

    def importAlunosFile(self):
        translator = self.getConfigAlunos()
        file_path = self._body
        CSVManager = CSV(file_path,translator)
        payload = CSVManager.read()

       # print("\n\n\n\n\nPAYLOAD:\n\n"+str(payload))
        if payload["status"] == "success":
            result = self._database.insertData("alunos",payload["data"])
        else:
            return "Erro ao ler o arquivo:" + payload["content"]
        # print("\n\n\n\n\nRESULT:\n\n"+str(result))

        if result["acknowledged"]:
            return sorted(result["data"],key= lambda d: d["matricula"])
        else:
            return "Erro ao inserir no banco"
        
    def createListasTurmas(self):

        turmas = self._database.getData("alunos",{},distinct="turma")
        
        listas = []
        for turma in turmas:
            lista = {"title":turma,"type":"class"}
            alunos_turma = self._database.getData("alunos",{"turma":turma})
            print(alunos_turma)
            matriculas = list(map(lambda a: a["matricula"],alunos_turma))
            lista["alunos"] = matriculas
            listas.append(lista)
        listas_criadas = self._database.insertData("listas",listas)
        if (listas_criadas["acknowledged"]):
            return listas
        else:
            return "Não foi possível criar as Turmas"
