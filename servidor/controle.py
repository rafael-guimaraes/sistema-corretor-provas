import asyncio
import websockets
import json 

from modelo.gerador import Gerador
from modelo.banco import Banco

async def requisicoes(websocket, path):
    async for message in websocket:
        dado = json.loads(message)
        
        json_resposta = ""
        await websocket.send(json_resposta)

async def socket():
    async with websockets.serve(requisicoes, "localhost", 5000):
        await asyncio.Future()
        
asyncio.run(socket())