import websockets as WS
from websockets.connection import Connection
import asyncio
from setup.env import env
import json
env = env()

class Emitter: 
    def __init__(self, task: str, sender) -> None:
        self._task = task
        self._connection = sender
        self._payload = None
        print(env.CHECKED+ __file__.replace(env.DIRECTORY,"") + "")

    def  _emit(self):
        if self._connection is None:
            print(env.WARNING+ __file__.replace(env.DIRECTORY,"") + " | Emitter()._emit() -> self._connection is None.")
            raise RuntimeError("Connection is not established.")
        self._connection.send(json.dumps({
            "sender":"backend",
            "task":self._task,
            "data":self._payload
        }))
        print(env.EMITTED+ __file__.replace(env.DIRECTORY,"") + " | Emitter.send() -> " + self._task + ": " + str( self._payload))
    def send(self, payload):
        self._payload = payload
        self._emit()
        return
        loop = asyncio.get_event_loop()
        if loop.is_running():
            # Se o loop já está rodando, agende a execução da coroutine
            task = loop.create_task(self._emit())
            return task
        else:
            # Se não há loop rodando, execute a coroutine usando asyncio.run
            asyncio.run(self._emit())

