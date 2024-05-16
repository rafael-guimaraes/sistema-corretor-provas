
from modelo.gerador import Gerador
from modelo.Banco import Banco

from controllers.Config import Config
from controllers.Alunos import Alunos
from controllers.Listas import Listas
import json 

def Router(database,Request) -> dict:

    task = Request["task"]
    context = Request["context"]
    payload = Request["body"]

    Response = ""

    if context == "Alunos":

        contextObject = Alunos(database)
        if task == "getAlunos":
            Response = contextObject.getAlunos(json.loads(payload))
        if task == "getAlunosByID":
            Response = contextObject.getAlunos({"matricula":payload})[0]
       

    elif context == "Listas":

        contextObject = Listas(database)
        if task == "getListas":
            Response = contextObject.getListas(json.loads(payload))
        if task == "deleteListByID":
            Response = contextObject.deleteListByID(payload)

    elif context == "Config":

        contextObject = Config(database)
        if task == "importListFile":
            Response = contextObject.importListFile(payload)
        if task == "importAlunosFile":
            Response = contextObject.importAlunosFile(payload)
            subTask = Listas(database)
            subResponse = subTask.createListasTurmas()
    print(Response)
    return {"data":Response,"task":task}

