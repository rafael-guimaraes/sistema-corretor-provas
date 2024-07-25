from pymongo.mongo_client import MongoClient
from pymongo.errors import ConnectionFailure, PyMongoError
from pymongo.database import Database as DB
from env import env
env = env()

def initialize_translators(db:DB):
    resultado = db[env.COLLECTION_CONFIG].insert_one(env.ALUNO_DEFAULT_TRANSLATOR).acknowledged 
    print(
        "[DONE] Tradutor de alunos criado." 
        if resultado
        else "[ERRO] Erro ao criar tradutor de alunos."
    )

def setup_rules(db:DB):
    resultado = db[env.COLLECTION_ALUNOS].create_index({"matricula":1}, unique=True)
    print ("[DONE] Regra de Matrícula única criada."
        if resultado == "matricula_1"
        else f"[ERRO] Erro ao criar Regra de Matrícula única. Resultado: {resultado}"
    )
    
def create_database():
    try:
        connection = MongoClient(env.MONGO_DB_URL)
        print(f"[DONE] Banco de dados criado." if connection.admin.command('ping') == {'ok': 1.0} 
              else "[ERRO] Erro ao criar banco de dados")
        database = connection[env.DATABASE_NAME]
        return database
    except ConnectionFailure as e:
        print("[ERRO] Não foi possível criar o banco de dados:", e)
    return None 

database = create_database()
if database is not None:
    initialize_translators(database)
    setup_rules(database)