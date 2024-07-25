from pymongo.mongo_client import MongoClient
from pymongo.errors import ConnectionFailure, PyMongoError
from pymongo.database import Database as DB
from colorama import Fore as F, Style as S
from env import env
env = env()

def initialize_translators(db:DB):
    resultado = db[env.COLLECTION_CONFIG].insert_one(env.ALUNO_DEFAULT_TRANSLATOR).acknowledged 
    print(
        F.GREEN + "[DONE]" + S.RESET_ALL + " mongo-config.py | initialize_translators() -> Tradutor de alunos criado." 
        if resultado
        else F.RED+ "[ERRO]" + S.RESET_ALL + " mongo-config.py | initialize_translators() -> Erro ao criar tradutor de alunos."
    )

def setup_rules(db:DB):
    resultado = db[env.COLLECTION_ALUNOS].create_index({"matricula":1}, unique=True)
    print (
        F.GREEN + "[DONE]" + S.RESET_ALL + " mongo-config.py | setup_rules() -> Regra de Matrícula única criada." 
        if resultado == "matricula_1"
        else F.RED+ "[ERRO]" + S.RESET_ALL + " mongo-config.py | setup_rules() -> Erro ao criar Regra de Matrícula única. Resultado: {resultado}"
    )
    
def create_database():
    try:
        connection = MongoClient(env.MONGO_DB_URL)
        print(
            F.GREEN + "[DONE]" + S.RESET_ALL + " mongo-config.py | create_database() -> Banco de dados criado."
            if connection.admin.command('ping') == {'ok': 1.0} 
            else F.RED+ "[ERRO]" + S.RESET_ALL + " mongo-config.py | create_database() -> Erro ao criar banco de dados."
        )
        database = connection[env.DATABASE_NAME]
        return database
    except ConnectionFailure as e:
        print(F.RED+ "[ERRO]" + S.RESET_ALL + " mongo-config.py | create_database() -> Não foi possível criar o banco de dados:", e)
    return None 

database = create_database()
if database is not None:
    initialize_translators(database)
    setup_rules(database)