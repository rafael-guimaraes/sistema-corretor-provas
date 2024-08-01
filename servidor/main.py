import asyncio
import websockets as WS
import json 
from pprint import pprint
from setup.env import env
env = env()
from modelo.banco import Banco


from Controller import Router

Database = Banco(env.MONGO_DB_URL)

async def API(sender, path):
    print(env.RUNNING + "| API() -> Sender:"+ str(sender))
    async for message in sender:
        print(message)
        Request = json.loads(message)

        print(env.DESKTOP+ __file__.replace(env.DIRECTORY,"") + " | Socket request: -> Task: " + Request["task"])
        Response = await Router(Database,Request,sender)
        if sender:
            await sender.send(str(Response))
            print(env.EMITTED+ __file__.replace(env.DIRECTORY,"") + " | Socket emitted: -> task: " + Response["task"])
        else:
            print(env.WARNING+ __file__.replace(env.DIRECTORY,"") + " | Socket emit: -> sender: Desktop")                

        print()
async def Socket():
    async with WS.serve(API, env.HOST, env.PORT):
        await asyncio.Future()
        
asyncio.run(Socket()) 
