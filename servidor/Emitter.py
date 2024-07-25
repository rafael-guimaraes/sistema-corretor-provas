import websockets as WS
from websockets.connection import Connection
import asyncio
from setup.env import env
import json
env = env()

class Emitter: 
    def __init__(self, task: str) -> None:
        self.URI = f"ws://{env.HOST}:{env.PORT}/"
        self.task = task
        self.connection = None

    async def _connect(self):
        self.connection = await WS.connect(self.URI)
        print(str(self.connection))
        print(env.CONNECT + "Emitter.py | Emitter.connect()")

    async def _emit(self, payload):
        if self.connection is None:
            raise RuntimeError("Connection is not established.")
        await self.connection.send(json.dumps(payload))
        print(env.EMITTED + "Emitter.py | Emitter.send() -> " + self.task + ": " + str(payload["body"]))

    async def send_async(self, payload):
        if self.connection is None:
            await self._connect()
        payload = {"body": payload, "task": self.task}
        await self._emit(payload)

    def send(self, payload):
        loop = asyncio.get_event_loop()
        if loop.is_running():
            # Se o loop já está rodando, agende a execução da coroutine
            task = loop.create_task(self.send_async(payload))
            return task
        else:
            # Se não há loop rodando, execute a coroutine usando asyncio.run
            asyncio.run(self.send_async(payload))

