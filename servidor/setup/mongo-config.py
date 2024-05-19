from pymongo.mongo_client import MongoClient
from pymongo.errors import ConnectionFailure, PyMongoError
from pymongo.database import Database as DB
from env import env
env = env()

def initialize_translators(db:DB):
    db[env.COLLECTION_CONFIG].insert_one(env.ALUNO_DEFAULT_TRANSLATOR)

def setup_rules(db:DB):
    db[env.COLLECTION_ALUNOS].create_index({"matricula":1}, unique=True)
    
def create_database():
    try:
        connection = MongoClient(env.MONGO_DB_URL)
        print(connection.admin.command('ping'))
        database = connection[env.DATABASE_NAME]
        return database
    except ConnectionFailure as e:
        print("Não foi possível criar o banco de dados:", e)
    return None 

database = create_database()
if database is not None:
    initialize_translators(database)
    setup_rules(database)


