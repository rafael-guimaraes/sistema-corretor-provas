from pymongo.mongo_client import MongoClient
from pymongo.server_api import ServerApi
from pymongo.errors import ConnectionFailure, PyMongoError

class Banco():
    def __init__(self, usuario, senha): 
        try:
            self.client = MongoClient()
            self.client.admin.command('ping')
            self.db = self.client['univap']
        except ConnectionFailure as e:
            print("Não foi possível conectar ao banco de dados:", e)
            self.client = None
            self.db = None

    def inserir_dados(self, colecao, dados):
        if self.db is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return

        colecao = self.db[colecao]
        try:
            if isinstance(dados, list):
                colecao.insert_many(dados)
            else:
                colecao.insert_one(dados)
        except PyMongoError as e:
            print("Erro ao inserir dados:", e)

    def buscar_dados(self, colecao, filtro = {}):
        if self.db is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return None

        colecao = self.db[colecao]
        try:
            return colecao.find(filtro)
        except PyMongoError as e:
            print("Erro ao buscar dados:", e)
            return None

    def atualizar_dados(self, colecao, novos_dados, filtro = {}):
        if self.db is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return

        colecao = self.db[colecao]
        try:
            colecao.update_many(filtro, {"$set": novos_dados})
        except PyMongoError as e:
            print("Erro ao atualizar dados:", e)

    def deletar_dados(self, colecao, filtro = {}):
        if self.db is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return

        colecao = self.db[colecao]
        try:
            colecao.delete_many(filtro)
        except PyMongoError as e:
            print("Erro ao deletar dados:", e)