class env:
    def __init__(self) -> None:
        self.MONGO_DB_URL ="mongodb://localhost:27017"
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
        self.AULAS_DEFAULT_TRANSLATOR = {
            "type": "translateAulas",
            "data": {
                "TURMA": "matricula",
                "DISCIPLINA": "nome",
                "NOME_DISCIPLINA": "turma",
                "NOME_DOCENTE": "serie",
                "SEMANA_EXTENSO": "situacao",
                "FREQUENCIA": "email",
                "HORAINICIALFINAL": "legal_email"
            }
        }


        self.COLLECTION_ALUNOS = "alunos"
        self.COLLECTION_LISTAS = "listas"
        self.COLLECTION_CONFIG = "configuracoes"
        self.COLLECTION_PROVAS = "provas"
        self.DATABASE_NAME = "univap"
        self.STATIC = "servidor/modelo/arquivos/"

def CSV_NOTATION(file):
    import csv
    with open(file, 'r') as file:
        sniffer = csv.Sniffer()
        # Read 5000 bytes to try detecting the delimiter
        sample = file.read(5000)
        dialect = sniffer.sniff(sample)
        return dialect.delimiter