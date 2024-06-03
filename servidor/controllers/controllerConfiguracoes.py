
from modelo.banco import Banco as DB
from modelo.ImportCSV import ImportCSV as CSV
from setup.env import env
env = env()

def getConfigAlunos(database:DB) -> dict:
    return database.getData(env.COLLECTION_CONFIG,{"type":env.ALUNO_DEFAULT_TRANSLATOR["type"]})[0]["data"]
    
        
def importListFile(database:DB,file_path):
    translator = getConfigAlunos(database)
    matricula = list(filter(lambda i: i[1] == "matricula",list(translator.items())))[0][0]
    print("Tradução matricula: "+ str(matricula))

    CSVManager = CSV(file_path,translator)
    payload = CSVManager.read()

    if payload["status"] == "success":
        # Pegar cada aluno para inserir na lista
        result = database.insertData(env.COLLECTION_ALUNOS,payload["data"])
    else:
        return "Erro ao ler o arquivo:" + payload["content"]

    if result["acknowledged"]:
        return sorted(result["data"],key= lambda d: d["matricula"])
    else:
        return "Erro ao inserir no banco"
        

def importAlunosFile(database:DB,file_path):
    translator = getConfigAlunos(database)
    
    CSVManager = CSV(file_path,translator)
    payload = CSVManager.read()

    if payload["status"] == "success":
        result = database.insertData(env.COLLECTION_ALUNOS,payload["data"])
    else:
        return "Erro ao ler o arquivo:" + payload["content"]

    if result["acknowledged"]:
        return sorted(result["data"],key= lambda d: d["matricula"])
    else:
        return "Erro ao inserir no banco"
