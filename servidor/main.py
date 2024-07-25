import asyncio
import websockets
import json 
from colorama import Fore as F, Style as S
from setup.env import env
env = env()
from modelo.banco import Banco


from Controller import Router


Database = Banco(env.MONGO_DB_URL)

async def API(websocket, path):
    async for message in websocket:
       
        Request = json.loads(message)
        
        Response = Router(Database,Request)
         
        sent = await websocket.send(str(Response))
     
        print(F.GREEN + "[DONE]" + S.RESET_ALL + " main.py | Socket emitted: -> " + Response["task"])

async def Socket():
    async with websockets.serve(API, "localhost", 5000):
        await asyncio.Future()
        
asyncio.run(Socket()) 