# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t3-mundo-veg/blob/main/docs/01-Documenta%C3%A7%C3%A3o%20de%20Contexto.md"> Documentação de Contexto</a></span>

A descrição do problema e os pontos mais relevantes a serem tratados neste projeto foram estabelecidos com a criação de personas e histórias de usuários que representam as necessidades de vegetarianos e veganos, e usuários em potencial da plataforma a ser desenvolvida.

## Personas

|Nº                  | FOTO                               |DESCRIÇÃO                               |
|--------------------|------------------------------------|----------------------------------------|
|1| ![image](https://user-images.githubusercontent.com/100447878/187459339-7b28e19b-fca7-4ba2-885f-82f305445730.png)| Miguel Torres tem 41 anos, é escritor e sócio de uma editora de livros infantis. Utiliza os aplicativos Instagram, Twitter e Facebook. Mora em Nova Lima (MG). É casado com Giovanna Souza, médica, e pai de duas filhas, Ana e Nina, de 5 e 7 anos. Gosta de ouvir músicas, viajar com a família e fazer passeios gastronômicos com a esposa. Miguel se sente frustrado por não sabe cozinhar; por causa da rotina corrida, ainda não conseguiu se organizar para dedicar um tempo à atividade física; não consegue encontrar receitas e alimentos saudáveis de forma prática, e se sente perdido em meio a tantas informações na internet e gostaria de substituir ocasionalmente a carne por proteínas vegetais em sua alimentação. Tem como motivações: quer aprender a cozinhar para que a sua alimentação e das filhas seja mais saudável; gostaria de envolver as filhas e a esposa para que cozinhar se torne uma atividade divertida em família e precisa mudar seus hábitos alimentares por indicação médica.|
  
Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros. 

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |
|Miguel Torres       | Localizar receitas saudáveis       | Cozinhar e melhorar a minha alimentação e da minha família. |
|Miguel Torres       | Localizar mercados com variedade de produtos saudáveis                | Pesquisar receitas que são preparadas com esses ingredientes. |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação interativa deve ser publicada em um ambiente acessível publicamente na Internet (GitHub Pages). | ALTA | 
|RNF-002| A aplicação interativa deverá ser responsiva permitindo a visualização em um celular de forma adequada. |  ALTA | 
|RNF-003| A aplicação interativa deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). |  ALTA | 
|RNF-004| A aplicação interativa deve ter bom nível de contraste entre os elementos da tela em conformidade. |  MÉDIA | 

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir:

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 11/12/2022. |
|02| A equipe não pode subcontratar o desenvolvimento do trabalho.        |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
