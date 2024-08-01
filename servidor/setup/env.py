from colorama import Fore as F, Style as S
class env:
    def __init__(self) -> None:
        self.HOST = "localhost"
        self.PORT = 5000
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
        self.DEFAULT_PASSWORD = {
            "type":"systemAuthorization",
            "password":"admin"
        }

        self.COLLECTION_ALUNOS = "alunos"
        self.COLLECTION_LISTAS = "listas"
        self.COLLECTION_CONFIG = "configuracoes"
        self.COLLECTION_PROVAS = "provas"
        self.DATABASE_NAME = "univap"
        self.STATIC = "servidor/modelo/arquivos/"
        self.DIRECTORY = "C:\\Users\\gabri\\Documents\\GitHub\\TCC\\servidor"
        self.RUNNING = F.YELLOW + "[RUNNING] " + S.RESET_ALL
        self.WARNING = F.RED + "[WARNING] " + S.RESET_ALL
        self.SUCCESS = F.LIGHTGREEN_EX + "[SUCCESS] " + S.RESET_ALL
        self.EMITTED = F.CYAN + "[EMITTED] " + S.RESET_ALL
        self.BACKEND = F.CYAN + "[BACKEND] " + S.RESET_ALL
        self.DESKTOP = F.CYAN + "[DESKTOP] " + S.RESET_ALL
        self.CONNECT = F.LIGHTWHITE_EX + "[CONNECT] " + S.RESET_ALL
        self.CHECKED = F.LIGHTBLUE_EX + "[CHECKED] " + S.RESET_ALL