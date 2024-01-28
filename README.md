# TCC
Trabalho de Conclusão de Curso 2024

## Autores:
- [Gabriel Costa Fileno](https://github.com/FILEN0)
- [Kaio Eduardo Braga Barbosa](https://github.com/kaio0824)
- [Rafael Augusto Guimarães da Silva](https://github.com/rafael-guimaraes)

## Módulos de desenvolvimento
- Correção de provas
- Geração de provas embaralhadas

## Descrição do projeto
### Aplicação Web
#### Recursos

<details><summary>👷‍♂️ Cargos</summary>
  
  - [ ] Administrador:
    -  Acesso total
  - [ ] Direção
  - [ ] Coordenador
  - [ ] Orientadora
  - [ ] Professor

</details> 
<details><summary>👨‍💻 Login único para todos os cargos</summary>

</details>
<details><summary>📝 Painel de criação de provas</summary>
    
- [ ] Criação de provas designadas: turma > geral
- [ ] Embaralhamento de questões
- [ ] Embaralhamento de alternativas <sub><sup>Uso de GPT para sugestões</sup></sub>
- <details><summary>🚥 Kanban: progresso por colunas</summary>
  
  - 🔴 Não iniciado
     - [ ] Botão de criar no topo
     - [ ] Cards das provas não iniciadas (sabe-se que deve ser criada/ cabeçalho já existe)
  - 🟠 Em Andamento
     - [ ] Cards das provas que estão sendo criadas, com algum numerador de questões <sub><sup>Ex.: 1/5 ou 20% das questões necessárias</sup></sub>
  - 🟡 Aguardando confirmação
     - [ ] Cards das provas que podem ser submetidas para o processo de impressão ou continuar criando questões
  - 🟢 Submetidas
     - [ ] Cards de provas criadas e submetidas para impressão
     - [ ] Passível de cancelamento

</details>

</details>
<details><summary>📊 Painel de relatórios</summary>

   - [ ] Acompanhamento de aluno
   - [ ] Projeção de notas
   - [ ] Desempenho das turmas
   - [ ] Gráfico de desempenho por bimestre
         
</details>
   
### Aplicação Desktop
#### Recursos

<details><summary>👨‍💻 Login na aplicação</summary>
         
</details>
<details><summary>⚙ Configurações</summary>

   - [ ] Definir numero de threads destinadas ao processo de leitura ( limite recomendado : numero de nucleos - 1) 
   - [ ] Definir pasta de leitura das imagens
   - [ ] Habilitar ou não o inicio automatico da aplicação, se positivo definir o intervalo
   - [ ] CRUD Administradores
         
</details>
<details><summary>💯 Correção das provas</summary>

   - [ ] Ler QRCode e Gabarito 
   - [ ] Extrair informações para banco local
   - [ ] Salvar em pasta designada
         
</details>
<details><summary>🖨 Impressão de overlay com gabarito e nota correta do aluno</summary>

   - [ ] Gerar o PDF
   - [ ] Nota do aluno
   - [ ] Gabarito correto

         
</details>
<details><summary>🗂️ Gerenciamento de processos de provas</summary>

- [ ] Visualizar histórico de correções
- [ ] Autor das correções
- [ ] Visualizar erros de leitura
- [ ] Filtros por bimestre, tipo de prova, disciplina e turma
- <details><summary>🚥 Kanban: progresso por colunas</summary>
  
  - 🔘 Em andamento
     - [ ] Cards das provas que estão sendo lidas, fração de alunos por turma <sub><sup>Ex.: 10/30 ou 33,33% das questões necessárias</sup></sub>
     - [ ] Processo automatizado de criação dos cards
  - 🟠 Leitura realizada
     - [ ] Cards das turmas que não tiveram todas as provas lidas (pendente substitutiva)
     - [ ] Apresentação dos erros de leitura
  - 🟡 Leitura completa
     - [ ] Cards de provas que possuem todos os alunos ou justificativa para avançar
     - [ ] Imprimir overlay
  - 🟢 Pronta para devolutiva
     - [ ] Cards de provas que possuem overlay impressa

</details>
         
</details>
