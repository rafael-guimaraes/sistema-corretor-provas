from pymongo.mongo_client import MongoClient
from pymongo.errors import ConnectionFailure, PyMongoError
from pymongo.database import Database as DB
from env import env
env = env()

def initialize_translators(db:DB):
    initialize_alunos_translator(db)
    initialize_default_login(db)
def initialize_alunos_translator(db:DB):
    try:
        result = db[env.COLLECTION_CONFIG].insert_one(env.ALUNO_DEFAULT_TRANSLATOR).acknowledged 
        print(
            env.SUCCESS + __file__.replace(env.DIRECTORY,"") + " | initialize_alunos_translator()" 
            if result
            else env.WARNING + __file__.replace(env.DIRECTORY,"") + " | initialize_alunos_translator()"
        )
    except Exception as e: 
        print(
            env.SUCCESS + __file__.replace(env.DIRECTORY,"") + " | initialize_alunos_translator() -> Already exists" 
            if "type_1 dup key" in str(e)
            else env.WARNING + __file__.replace(env.DIRECTORY,"") + " | initialize_alunos_translator() -> " + str(e)
        )
def initialize_default_login(db:DB):
    try:
        result = db[env.COLLECTION_CONFIG].insert_one(env.DEFAULT_PASSWORD).acknowledged 
        print(
            env.SUCCESS + __file__.replace(env.DIRECTORY,"") + " | initialize_default_login()" 
            if result
            else env.WARNING + __file__.replace(env.DIRECTORY,"") + " | initialize_default_login()"
        )
    except Exception as e: 
       print(
            env.SUCCESS + __file__.replace(env.DIRECTORY,"") + " | initialize_default_login() -> Already exists" 
            if "type_1 dup key" in str(e)
            else env.WARNING + __file__.replace(env.DIRECTORY,"") + " | initialize_default_login() -> " + str(e)
        )

def setup_rules(db:DB):
    setup_aluno_rule(db)
    setup_config_rule(db)

def setup_aluno_rule(db:DB):
    result = db[env.COLLECTION_ALUNOS].create_index({"matricula":1}, unique=True)
    print (
        env.SUCCESS + __file__.replace(env.DIRECTORY,"") + " | setup_aluno_rule() -> Unique rule for 'matricula' " 
        if result == "matricula_1"
        else env.WARNING + __file__.replace(env.DIRECTORY,"") + " | setup_aluno_rule() -> Unique rule for 'matricula'.\n\tResult: {resultado}"
    )
def setup_config_rule(db:DB):
    result = db[env.COLLECTION_CONFIG].create_index({"type":1}, unique=True)
    print (
        env.SUCCESS + __file__.replace(env.DIRECTORY,"") + " | setup_config_rule() -> Unique rule for 'type' " 
        if result == "type_1"
        else env.WARNING + __file__.replace(env.DIRECTORY,"") + " | setup_config_rule() -> Unique rule for 'type'.\n\tResult: {resultado}"
    )
    
def create_database():
    try:
        connection = MongoClient(env.MONGO_DB_URL)
        print(
            env.SUCCESS + __file__.replace(env.DIRECTORY,"") + " | create_database()"
            if connection.admin.command('ping') == {'ok': 1.0} 
            else env.WARNING + __file__.replace(env.DIRECTORY,"") + " | create_database()"
        )
        database = connection[env.DATABASE_NAME]
        return database
    except ConnectionFailure as e:
        print(env.WARNING + __file__.replace(env.DIRECTORY,"") + " | create_database() -> ", e)
    return None 

database = create_database()
if database is not None:
    setup_rules(database)
    initialize_translators(database)