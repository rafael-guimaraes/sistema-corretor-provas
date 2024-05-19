class env:
    def __init__(self) -> None:
        self.MONGO_DB_URL ="mongodb://localhost:27017"
        self.CSV_NOTATION = ","
        self.ALUNO_DEFAULT_TRANSLATOR = {
            "type": "translateAlunos",
            "data": {
                "ALUNO": "matricula",
                "NOME_ALUNO": "nome",
                "TURMA_PREF": "turma",
                "SERIE": "serie",
                "SIT": "situacao",
                "ALUNO_EMAIL": "email",
                "LEGAL_EMAIL": "legal_email"
            }
        }

        self.COLLECTION_ALUNOS = "alunos"
        self.COLLECTION_LISTAS = "listas"
        self.COLLECTION_CONFIG = "config"
        self.DATABASE_NAME = "univap"