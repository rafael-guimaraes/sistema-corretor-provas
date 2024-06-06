import asyncio
import websockets
import json 
from setup.env import env
env = env()
from modelo.banco import Banco

from Controller import Router


Database = Banco(env.MONGO_DB_URL)

async def API(websocket, path):
    async for message in websocket:
        print("-" * 60)
        print(message)
        print("-" * 60)
        
        Request = json.loads(message)
        Response = Router(Database,Request)
        sent = await websocket.send(str(Response))
        print(Response)
        print("FIM")

async def Socket():
    async with websockets.serve(API, "localhost", 5000):
        await asyncio.Future()
        
asyncio.run(Socket()) 