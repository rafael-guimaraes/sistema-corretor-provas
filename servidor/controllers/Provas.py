from modelo.gerador import Gerador

def Provas(database, task,  body):
    if task == "createProva":
        print(body)
        gerador = Gerador(body["arquivo"])
        
        dados = {
            "<turma>":"3H",
            "<professor>":"Alberson",
            "<titulo>":"Prova POO"
        }
        alunos = [{"matricula":50220326,"nome":"Gabriel Costa Fileno"},
                                                                    {"matricula":50220384,"nome":"Kaio Eduardo Braga Barbosa"},
                                                                    {"matricula":50220306,"nome":"Rafael Augusto Guimarães da Silva"}]

        provas = gerador.gerar_provas(dados, alunos, 2)
        database.insertData('provas', provas)
        return provas
    return None