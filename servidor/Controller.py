
from modelo.gerador import Gerador
from modelo.Banco import Banco

from controllers.Config import Config
from controllers.Alunos import Alunos
from controllers.Listas import Listas

def Router(database,Request) -> dict:

    task = Request["task"]
    context = Request["context"]
    payload = Request["body"]

    if context == "Alunos":
        contextObject = Alunos(database,task,payload)

    elif context == "Listas":
        contextObject = Listas(database,task,payload)

    elif context == "Config":
        contextObject = Config(database,task,payload)

    return {"data":contextObject.runTask(),"task":task}

