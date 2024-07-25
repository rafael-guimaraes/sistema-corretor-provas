from pymongo.mongo_client import MongoClient
from pymongo.errors import ConnectionFailure, PyMongoError
from pymongo.database import Database as DB
from env import env
env = env()

def initialize_translators(db:DB):
    result = db[env.COLLECTION_CONFIG].insert_one(env.ALUNO_DEFAULT_TRANSLATOR).acknowledged 
    print(
        env.SUCCESS + "mongo-config.py | initialize_translators()" 
        if result
        else env.WARNING + "mongo-config.py | initialize_translators()"
    )

def setup_rules(db:DB):
    result = db[env.COLLECTION_ALUNOS].create_index({"matricula":1}, unique=True)
    print (
        env.SUCCESS + "mongo-config.py | setup_rules() -> Unique rule for 'matricula' " 
        if result == "matricula_1"
        else env.WARNING + "mongo-config.py | setup_rules() -> Unique rule for 'matricula'.\n\tResult: {resultado}"
    )
    
def create_database():
    try:
        connection = MongoClient(env.MONGO_DB_URL)
        print(
            env.SUCCESS + "mongo-config.py | create_database()"
            if connection.admin.command('ping') == {'ok': 1.0} 
            else env.WARNING + "mongo-config.py | create_database()"
        )
        database = connection[env.DATABASE_NAME]
        return database
    except ConnectionFailure as e:
        print(env.WARNING + "mongo-config.py | create_database() -> ", e)
    return None 

database = create_database()
if database is not None:
    initialize_translators(database)
    setup_rules(database)