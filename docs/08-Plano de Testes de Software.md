# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t3-mundo-veg/blob/main/docs/02-Especifica%C3%A7%C3%A3o%20do%20Projeto.md"> Especificação do Projeto</a></span>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t3-mundo-veg/blob/main/docs/04-Projeto%20de%20Interface.md"> Projeto de Interface</a>

Apresentamos abaixo os cenários de testes elaborados para a realização dos testes da aplicação interativa, demonstrando os requisitos funcionais sendo satisfeitos.
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil de usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação interativa deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa <br> - Clicar em "Cadastro" na página inicial <br> - Clicar em “Cliente” no menu de cadastro <br> - Preencher os campos obrigatórios (CPF, nome, e-mail, telefone, rua, número, bairro, cidade, estado, CEP, categoria) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Cadastrar estabelecimentos**	|
|Requisito Associado | RF-002 - A aplicação interativa deve permitir aos donos de restaurantes e mercados cadastrar uma conta com informações sobre o estabelecimento. |
| Objetivo do Teste 	| Verificar se o estabelecimento consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa <br> - Clicar em "Cadastro" na página inicial <br> - Clicar em “Estabelecimento” nas opções  <br> - Preencher os campos obrigatórios <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Efetuar login**	|
|Requisito Associado | RF-003 - A aplicação interativa deve permitir ao usuário cadastrado fazer o login da sua conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa <br> - Clicar em "Login" na página inicial <br> - Preencher os campos obrigatórios <br> - Clicar em "Entrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Filtro/pesquisa de produtos e receitas**	|
|Requisito Associado | RF-004 - A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar produtos e receitas. |
| Objetivo do Teste 	| Verificar se a funcionalidade de filtrar/pesquisar é feita corretamente. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa <br> - Clicar em "Produtos" ou "Receitas" <br> - Preencher o campo "Filtrar" |
|Critério de Êxito | - Os dados inseridos no filtro de pesquisa devem mostrar os produtos e receitas onde há o dado informado. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Filtro/pesquisa de estabelecimentos**	|
|Requisito Associado | RF-005 - A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar restaurantes e mercados vegetarianos e veganos. |
| Objetivo do Teste 	| Verificar se a funcionalidade de filtrar/pesquisar é feita corretamente. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa <br> - Clicar em “Estabelecimentos” <br> - Preencher o campo "Filtrar" |
|Critério de Êxito | - Os dados inseridos do filtro de pesquisa devem mostrar corretamente os estabelecimentos filtrados. |
|   |   |
| **Caso de Teste** 	| **CT-06 – Filtro/pesquisa de receitas através de ingredientes**	|
|Requisito Associado | RF-006 - A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário pesquisar receitas através de ingredientes específicos. |
| Objetivo do Teste 	| Verificar se a funcionalidade de filtrar/pesquisar é feita corretamente. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa<br> - Clicar em “Receitas” <br> - Preencher o campo "Filtrar" |
|Critério de Êxito | - Os dados inseridos do filtro de pesquisa devem mostrar corretamente as receitas filtradas que contém o ingrediente pesquisado. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Visualizar informações dos estabelecimentos**	|
|Requisito Associado |RF-007	A aplicação interativa deve permitir ao usuário visualizar as informações de contato dos estabelecimentos. |
| Objetivo do Teste 	| Verificar se usuário tem acesso as informações de contato dos estabelecimentos. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa<br> - Clicar em “Estabelecimentos” <br> - Preencher o campo "Filtrar" com o estabelecimento desejado <br> - Clicar no icone do "Estabelecimento" exibido para visualizar informações de contato |
|Critério de Êxito | - Os dados inseridos do filtro de pesquisa devem mostrar corretamente os estabelecimentos filtrados e suas respectivas informações de contato. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Contactar os estabelecimentos através do WhatsApp**	|
|Requisito Associado | RF-008	A aplicação interativa deve permitir ao usuário entrar em contato com os estabelecimentos. |
| Objetivo do Teste 	| Verificar se a funcionalidade de contactar os estabelecimentos através do WhatsApp funciona corretamente. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa<br> - Clicar em “Estabelecimentos” <br> - Preencher o campo "Filtrar" com o estabelecimento desejado <br> - Clicar no ícone do "Estabelecimento" exibido para visualizar informações de contato <br> - Clicar em "número de telefone X" ou no ícone "WhatsApp" <br> - Redirecionamento para "WhatsApp" |
|Critério de Êxito | - O usuário consegue contactar o estabelecimento por "WhatsApp" através da aplicação interativa. |
|  	|  	|
| **Caso de Teste** 	| **CT-09 – Cadastrar receitas**	|
|Requisito Associado | RF-009	A aplicação interativa deve permitir o cadastro de receitas pelos usuários logados na plataforma. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar receitas na plataforma. |
| Passos 	| - Acessar o navegador <br> -Acessar a aplicação interativa<br> - Efetuar o Login <br> - Clicar em "Cadastrar" na página inicial <br> - Selecionar a opção "Receitas" <br> - Preencher os campos obrigatórios na área de cadastro de receitas <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro de receita foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-10 – Gerenciar conta**	|
|Requisito Associado | RF-010	A aplicação interativa deve permitir ao usuário gerenciar a sua conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerenciar sua conta. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa <br> - Clicar em "Login" na página inicial <br> - Acessar/gerenciar dados cadastrados em "Perfil" - Clicar no botão "Editar" - Salvar as alterações realizadas clicando no botão "Salvar" |
|Critério de Êxito | - O usuário consegue gerenciar sua conta. |
|  	|  	|
| **Caso de Teste** 	| **CT-11 – Cadastrar produtos**	|
|Requisito Associado | RF-011	A aplicação interativa deve permitir o cadastro de produtos pelos estabelecimentos logados na plataforma. |
| Objetivo do Teste 	| Verificar se o mercado consegue cadastrar produtos na plataforma. |
| Passos 	| - Acessar o navegador <br> - Acessar a aplicação interativa <br> - Efetuar o Login <br> - Clicar em "Cadastrar" na página inicial <br> - Selecionar a opção "Produtos" <br> - Preencher os campos obrigatórios na área de cadastro de produtos <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro de produtos foi realizado com sucesso. |
