from pymongo.mongo_client import MongoClient
from pymongo.server_api import ServerApi
from pymongo.errors import ConnectionFailure, PyMongoError
from bson.objectid import ObjectId

class Banco():
    def __init__(self,url:str): 
        try:
            self.connection = MongoClient(url)
            print(self.connection.admin.command('ping'))
            self.database = self.connection.univap
        except ConnectionFailure as e:
            print("Não foi possível conectar ao banco de dados:", e)
            self.connection = None
            self.database = None

    def strObjectID(self,data:list|tuple):
        new_list = []
        for item in data:
            new_dict = {}
            for k,v in item.items():
                new_dict[k] = str(v) if k == "_id" else v
            new_list.append(new_dict)            
        return new_list
    
    def insertData(self, collection, data):
        if self.database is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return 
        collection = self.database[collection]
        try:
            if type(data) not in (list,tuple) :
                data = [data]

            result = collection.insert_many(data, ordered=False)

            response = {
                "acknowledged": result.acknowledged,
                "data":self.strObjectID(data)
            }
            return response
        
        except PyMongoError as e:
            print("Erro ao inserir dados:", e)
            response = {
                "acknowledged": False,
                "data":e["nInserted"]
            }

    def getData(self, collection, filter = {}, distinct = False):
        if self.database is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return None

        collection = self.database[collection]
        try:
            if not distinct:
                result = self.strObjectID(list(collection.find(filter)))
            else:
                result = list(collection.distinct(distinct))
            return result
        except PyMongoError as e:
            print("Erro ao buscar dados:", e)
            return None

    def updateData(self, colecao, novos_dados, filtro = {}):
        if self.database is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return

        colecao = self.database[colecao]
        try:
            colecao.update_many(filtro, {"$set": novos_dados})
        except PyMongoError as e:
            print("Erro ao atualizar dados:", e)

    def deleteData(self, colecao, filtro = {}):
        if self.database is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return

        colecao = self.database[colecao]
        try:
            return colecao.delete_many(filtro)
        except PyMongoError as e:
            print("Erro ao deletar dados:", e)
    
    def deleteDataByID(self, collection, id=None):
        if self.database is None:
            print("Erro: Não foi possível acessar o banco de dados.")
            return
        
        collection = self.database[collection]

        object_id = ObjectId(id)
        try:
            return collection.delete_one({"_id": object_id})
        except PyMongoError as e:
            print("Erro ao deletar dados:", e)