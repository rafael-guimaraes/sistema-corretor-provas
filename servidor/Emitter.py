import websockets as WS
from websockets.connection import Connection
import asyncio
from setup.env import env
import json
env = env()

async def emit(task,sender,payload):
    if sender is None:
        print(env.WARNING+ __file__.replace(env.DIRECTORY,"") + " | Emitter()._emit() -> sender is None.")
        raise RuntimeError("Connection is not established.")
    response = str({
        "sender":"backend",
        "task":task,
        "data":payload
    })
    await sender.send(response)
    await asyncio.sleep(0)
    
    print(env.EMITTED + __file__.replace(env.DIRECTORY,"") + " | Emitter.send() -> " + task + ": " + str(payload))


