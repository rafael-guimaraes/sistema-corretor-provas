
from modelo.gerador import Gerador
from modelo.banco import Banco as DB

from controllers.controllerConfiguracoes import *
from controllers.controllerAlunos import *
from controllers.controllerListas import *
from controllers.controllerProvas import *
import json 

def Router(database:DB,Request) -> dict:

    task = Request["task"]
    context = Request["context"]
    payload = Request["body"]

    Response = ""

    if context == "Alunos":
        
        if task == "getAlunos":
            Response = getAlunos(database,json.loads(payload))
        if task == "getAlunosByID":
            Response = getAlunos(database,{"matricula":payload})[0]
       


    elif context == "Listas":

        if task == "getListas":
            Response = getListas(database,json.loads(payload))
        if task == "deleteListByID":
            Response = deleteListByID(database, payload)


    elif context == "Config":

        if task == "importListFile":
            Response = importListFile(database,payload)
        if task == "importAlunosFile":
            preResponse = clearAlunos(database)
            Response = importAlunosFile(database,payload)
            subResponse = createListasTurmas(database)



    elif context == "Provas":
        if task == "createProva":
            Response = createProva(database, json.loads(payload))
        elif task == "createExemplo":
            Response = createExample(database, json.loads(payload))
        
    return {"data":Response,"task":task}

