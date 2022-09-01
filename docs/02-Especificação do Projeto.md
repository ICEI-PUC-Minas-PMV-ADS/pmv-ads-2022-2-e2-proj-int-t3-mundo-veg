# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t3-mundo-veg/blob/main/docs/01-Documenta%C3%A7%C3%A3o%20de%20Contexto.md"> Documentação de Contexto</a></span>

A descrição do problema e os pontos mais relevantes a serem tratados neste projeto foram estabelecidos com a criação de personas e histórias de usuários que representam as necessidades de vegetarianos e veganos, e usuários em potencial da plataforma a ser desenvolvida.

## Personas

|Nº                  | FOTO                               |DESCRIÇÃO                               |
|--------------------|------------------------------------|----------------------------------------|
|1| ![image](https://user-images.githubusercontent.com/100447878/187459339-7b28e19b-fca7-4ba2-885f-82f305445730.png)| Miguel Torres tem 41 anos, é escritor e sócio de uma editora de livros infantis. Utiliza os aplicativos Instagram, Twitter e Facebook. Mora em Nova Lima (MG). É casado com Giovanna Souza, médica, e pai de duas filhas, Ana e Nina, de 5 e 7 anos. Gosta de ouvir músicas, viajar com a família e fazer passeios gastronômicos com a esposa. Miguel se sente frustrado por não sabe cozinhar; por causa da rotina corrida, ainda não conseguiu se organizar para dedicar um tempo à atividade física; não consegue encontrar receitas e alimentos saudáveis de forma prática, e se sente perdido em meio a tantas informações na internet e gostaria de substituir ocasionalmente a carne por proteínas vegetais em sua alimentação. Tem como motivações: quer aprender a cozinhar para que a sua alimentação e das filhas seja mais saudável; gostaria de envolver as filhas e a esposa para que cozinhar se torne uma atividade divertida em família e precisa mudar seus hábitos alimentares por indicação médica.|
|2|![luana](https://user-images.githubusercontent.com/81182674/187477869-3cf0e06b-5b75-491f-872a-bc9afa002302.jpg) | Luana Almeida tem 35 anos e é dona de um restaurante vegano. Utiliza aplicativos como Instagram e Facebook. Mora em Belo Horizonte, tem uma filha de 5 anos, adora viajar e conhecer novas culturas. Se sente frustrada por não estar conseguindo atrair novos clientes para seu restaurante, e com a dificuldade em torná-lo mais conhecido. Tem como motivações, poder anunciar as refeições de seu restaurante em um local onde refeições veganas tenham maior visibilidade, e torná-lo um dos melhores de Belo Horizonte.|
|3|![julia](https://user-images.githubusercontent.com/98122346/187755857-c57f96a3-1d50-4f2e-9fed-da3f65c54886.jpg)| Júlia Araújo tem 32 anos e é artista plástica. Utiliza os aplicativos Instagram, Facebook e Behance. Mora em Recife com sua noiva. Desde pequena ama pintura em tela e está sempre viajando e expondo suas obras de artes em várias galerias ao redor do Brasil. Júlia se sente frustrada por ter dificuldade de encontrar produtos 100% veganos; tem dificuldade em montar pratos veganos por falta de conhecimento; não consegue em suas viagens achar com facilidade restaurantes com opções veganas. Tem como motivações: Aderiu ao veganismo faz pouco tempo, necessitando de dicas de receitas para facilitar em sua transição; por viajar muito por lugares novos e quase sempre não conhecer restaurantes com opções veganas, necessita de um aplicativo que lhe possa ajudar; ao aprender a fazer receitas veganas variadas e de qualidade, estaria incentivando também a sua noiva a se inserir no estilo vegano.|
|4| | |
|5| | |
|6| | |

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |
|Miguel Torres       | Localizar receitas saudáveis       | Cozinhar e melhorar a minha alimentação e da minha família. |
|Miguel Torres       | Localizar mercados com variedade de produtos saudáveis                | Pesquisar receitas que são preparadas com esses ingredientes. |
|Luana Almeida       |anunciar as refeições de seu restaurante         | para aumentar sua clientela              |
|Júlia Araújo        | localizar receitas veganas          | para facilitar na introdução ao estilo vegano ao cozinhar minhas próprias refeições           |
|Júlia Araújo        | localizar restaurantes veganos e/ou com opções veganas | para facilitar quando estiver viajando        |
|Júlia Araújo        | localizar mercados com produtos 100% veganos | para o preparo de minhas refeições    |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação interativa deve permitir ao usuário cadastrar uma conta. | ALTA | 
|RF-002| A aplicação interativa deve permitir aos donos de restaurantes e mercados cadastrar uma conta com informações sobre o estabelecimento e produtos.   | ALTA |
|RF-003| A aplicação interativa deve permitir ao usuário cadastrado fazer o login da sua conta.   | ALTA |
|RF-004| A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar alimentos, produtos e receitas.   | ALTA |
|RF-005| A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar restaurantes e mercados vegetarianos e veganos. | ALTA |
|RF-006| A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário pesquisar receitas através de ingredientes específicos.    | MÉDIA |
|RF-007| A aplicação interativa deve permitir ao usuário visualizar as informações de contato dos restaurantes e mercados.   | MÉDIA |
|RF-008| A aplicação interativa deve permitir ao usuário entrar em contato com os restaurantes e mercados através do WhatsApp, para que ele faça o pedido da compra diretamente com os estabelecimentos.   | ALTA |
|RF-009| A aplicação interativa deve permitir o cadastro de receitas pelos usuários logados na plataforma.   | ALTA |
|RF-010| A aplicação interativa deve permitir ao usuário gerenciar a sua conta.   | ALTA |

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
