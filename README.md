# Sistema de Criação e Correção de Provas

Projeto desenvolvido como Trabalho de Conclusão de Curso (TCC) do Curso Técnico em Informática do Colégio Técnico “Antônio Teixeira Fernandes” (Univap – Unidade Centro).  
Atualmente em produção e utilizado pelos colégios Univap (Unidade Centro).

Artigo publicado na WICS/SBC: [doi.org/10.5753/wics.2025.9286](https://doi.org/10.5753/wics.2025.9286)

---

## Sobre o projeto
O sistema foi desenvolvido para otimizar a criação, aplicação e correção de provas objetivas em ambiente escolar.  
Ele permite que professores e funcionários economizem tempo e reduzam erros no processo avaliativo, garantindo também inclusão e acessibilidade para alunos com deficiência visual.

### Principais funcionalidades:
- Geração automática de provas em formato Word, a partir de um modelo editado pelo professor.  
- Embaralhamento de questões e alternativas, criando provas únicas para cada aluno.  
- Identificação nominal das provas com dados do aluno (nome, matrícula e turma).  
- Provas acessíveis com fontes ampliadas para alunos com baixa visão.  
- Correção automática via OMR (Optical Mark Recognition) utilizando OpenCV.  
- Identificação do aluno por QR Code, garantindo que cada gabarito corresponda à prova correta.  
- Gerenciamento visual de avaliações via Kanban, facilitando o acompanhamento do ciclo avaliativo (criação, impressão, correção e devolução).  
- Exportação de resultados em CSV para integração com sistemas escolares.  

---

## Tecnologias utilizadas
- Aplicação desktop em **C# (Windows Forms)** para a interface e gerenciamento de avaliações.  
- Módulos de serviço em **Python**, responsáveis por manipulação de documentos, processamento de imagens (OpenCV, ZBar) e embaralhamento de gabaritos.  
- **MongoDB** para armazenamento flexível dos dados.  
- Comunicação entre módulos via **WebSockets** para atualização em tempo real.  

---

## Como funciona
1. O professor elabora a prova no modelo `.docx` fornecido pelo sistema.  
2. O software processa o documento, gera versões embaralhadas e personalizadas para cada aluno.  
3. As provas são aplicadas em sala de aula.  
4. Após digitalização (scanner), o sistema corrige automaticamente via processamento de imagem e QR Code.  
5. Os resultados podem ser revisados manualmente, exportados e devolvidos aos alunos.  

---

## Resultados
- Alta precisão na leitura automática das respostas, com suporte a revisão manual.  
- Correção em média de 3 segundos por prova (contra até 4 horas no processo manual de turmas grandes).  
- Inclusão: suporte a alunos com baixa visão.  
- Segurança: redução de fraudes por compartilhamento de gabaritos.  
- Viabilidade prática: o sistema está em funcionamento em um colégio com mais de 1000 alunos durante todo o ano de 2025.  

---

## Monografia / Trabalho de Conclusão de Curso
O projeto possui uma monografia detalhando todo o desenvolvimento, metodologia, resultados e referências.  
Você pode acessar o arquivo completo aqui:  

[Download da Monografia (PDF)](https://github.com/user-attachments/files/22323485/Monografia.-.TCC.-.Versao.Final.pdf)


---

## Publicação científica
Este projeto originou o artigo apresentado no Workshop de Iniciação Científica em Sistemas de Computação (WICS) da SBC:  

> Gabriel Costa Fileno, Kaio Eduardo Braga Barbosa, Rafael Augusto Guimarães da Silva.  
> *Sistema de criação e correção de provas de múltipla escolha com embaralhamento de gabaritos integrado.*  
> WICS, 2025. DOI: [10.5753/wics.2025.9286](https://doi.org/10.5753/wics.2025.9286)  

A apresentação no evento foi realizada por **Gabriel Costa Fileno**, sob coordenação do comitê organizado pelo Prof. Johnny da Silva (ITA).  

---
## Capturas de Telas
### Arquivo de Prova Modelo
Exemplo de arquivo `.docx` usado como modelo pelo sistema para geração das provas.  
![Arquivo de Prova Modelo](https://github.com/user-attachments/assets/2780ca9b-b422-4996-9a71-ccf085033530)

### Comparativo de Provas
Demonstra provas geradas automaticamente pelo sistema com e sem ampliação para acessibilidade visual.  
![Comparativo de Provas](https://github.com/user-attachments/assets/817a69a1-04a3-4062-a2bf-6d09ad90e61a)

### Tela Principal - Kanban
Exibe a visão geral do sistema com o gerenciamento de avaliações via metodologia Kanban.  
![Tela Principal do Sistema](https://github.com/user-attachments/assets/c04323d2-646f-410b-a168-6cd4e62a5883)

### Fluxo de Processamento de Imagem
Ilustra o processamento automatizado de gabaritos via OCR/QR Code para correção das provas.  
![Fluxo de Processamento de Imagem](https://github.com/user-attachments/assets/0fb89eac-0fbe-440d-849a-61d92e48bbae)


## Autores
- Gabriel Costa Fileno  
- Kaio Eduardo Braga Barbosa  
- Rafael Augusto Guimarães da Silva  

Orientador: Prof. Me. Hélio Lourenço Esperidião Ferreira  

---


