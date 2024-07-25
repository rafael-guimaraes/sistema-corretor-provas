import asyncio
import websockets as WS
import json 
from setup.env import env
env = env()
from modelo.banco import Banco


from Controller import Router


Database = Banco(env.MONGO_DB_URL)

async def API(websocket, path):
    print(env.RUNNING + "main.py | API() -> "+ str(websocket))
    async for message in websocket:
       
        Request = json.loads(message)

        print(env.REQUEST + "main.py | Socket request: -> task: " + Request["task"])
        
        Response = Router(Database,Request)
         
        sent = await websocket.send(str(Response))
     
        print(env.EMITTED + "main.py | Socket emitted: -> task: " + Response["task"])

async def Socket():
    async with WS.serve(API, env.HOST, env.PORT):
        await asyncio.Future()
        
asyncio.run(Socket()) 