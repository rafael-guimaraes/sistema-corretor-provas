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
                payload = str({"status":200,"body":[{"ID":1,"titulo":"Lista1"},{"ID":2,"titulo":"Lista2"}]})
        else:
            payload = str({"status":400,"body":"Bad Request"})




        a = await websocket.send(payload)
        print("envio:" + str(a))
        print("enviado:" + payload)

async def socket():
    async with websockets.serve(requisicoes, "localhost", 5000):
        await asyncio.Future()
        
asyncio.run(socket())