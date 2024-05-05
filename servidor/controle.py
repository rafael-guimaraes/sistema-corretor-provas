import asyncio
import websockets
import json 

from modelo.gerador import Gerador
from modelo.banco import Banco

async def requisicoes(websocket, path):
    async for message in websocket:
        print(message)
        request = json.loads(message)
        if request["route"] == "listas":
            #criar objecto controller listas
            if request["method"] == "GET":
                # Busca no banco
                # retorna listas
                payload = str({"status":200,"body":[{"ID":1,"titulo":"Lista1"},{"ID":2,"titulo":"Lista2"}]})
            if request["method"] == "DELETE":
                # Remove no banco
                #retorna listas remanescentes
                payload = str({"status":200,"body":filter(lambda x: x["ID"] != request["body"]["ID"],
                                                          [{"ID":1,"titulo":"Lista1"},{"ID":2,"titulo":"Lista2"}])})
            if request["method"] == "POST":
                print (request["body"])
                #Recebe algo similar a isto: {"nome":"Nova Lista", "alunos":[50220326,50220384]}
                # Cria lista com alunos e nome
                # retorna lista de listas
                # retorna campo "selecionada":"nome_da_lista"
                payload = str

        elif request["route"] == "alunos":
            if request["method"] == "GET":
                if (request["body"]["filtro"]):
                    
                    filtro = request["body"]["filtro"]
                    
                    if (filtro == "matricula"):
                        print ("CAIU AQUI")
                        print (request)
                        matricula = request["body"]["matricula"]
                        if matricula == 50220326:
                            item = {"matricula":50220326,"aluno":"Gabriel Costa Fileno"}
                        elif matricula == 50220384:
                            item = {"matricula":50220384,"aluno":"Kaio Eduardo Braga Barbosa"}
                        elif matricula == 50220306:
                            item = {"matricula":50220306,"aluno":"Rafael Augusto Guimarães da Silva"}
                        else:
                            item = {}

                        
                        payload = str({"status":200,"body":item})
                    else:#filtrar por nome
                        payload = str({"status":200,"body":[{"matricula":50220326,"aluno":"Gabriel Costa Fileno"},
                                                            {"matricula":50220384,"aluno":"Kaio Eduardo Braga Barbosa"},
                                                            {"matricula":50220306,"aluno":"Rafael Augusto Guimarães da Silva"}]})
                else:
                    payload = str({"status":200,"body":[{"matricula":50220326,"aluno":"Gabriel Costa Fileno"},
                                                        {"matricula":50220384,"aluno":"Kaio Eduardo Braga Barbosa"},
                                                        {"matricula":50220306,"aluno":"Rafael Augusto Guimarães da Silva"}]})
        else:
            payload = str({"status":400,"body":"Bad Request"})




        a = await websocket.send(payload)
        print("envio:" + str(a))
        print("enviado:" + payload)

async def socket():
    async with websockets.serve(requisicoes, "localhost", 5000):
        await asyncio.Future()
        
asyncio.run(socket())