# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 


 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil de usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação interativa deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Cadastro" na página inicial <br> - Clicar em “Cliente” na página de cadastro <br> - Preencher os campos obrigatórios (nome completo, e-mail, telefone, endereço, senha, confirmação de senha) <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Cadastrar mercado/restaurante**	|
|Requisito Associado | RF-002 - A aplicação interativa deve permitir aos donos de restaurantes e mercados cadastrar uma conta com informações sobre o estabelecimento e produtos. |
| Objetivo do Teste 	| Verificar se o estabelecimento consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Cadastro" na página inicial <br> - Clicar em “Estabelecimento” na página de cadastro  <br> - Preencher os campos obrigatórios <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Efetuar login**	|
|Requisito Associado | RF-003 - A aplicação interativa deve permitir ao usuário cadastrado fazer o login da sua conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Entrar" na página inicial <br> - Preencher os campos obrigatórios <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Filtro/pesquisa de alimentos, produtos e receitas**	|
|Requisito Associado | RF-004 - A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar alimentos, produtos e receitas. |
| Objetivo do Teste 	| Verificar se a funcionalidade de filtrar/pesquisar é feita corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Preencher o campo "Filtrar" |
|Critério de Êxito | - Os dados inseridos no filtro de pesquisa devem mostrar os alimentos, produtos e receitas onde há o dado informado. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Filtro/pesquisa de restaurantes e mercados**	|
|Requisito Associado | RF-005 - A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar restaurantes e mercados vegetarianos e veganos. |
| Objetivo do Teste 	| Verificar se a funcionalidade de filtrar/pesquisar é feita corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em “Mercado” e/ou “Restaurante” <br> - Preencher o campo "Filtrar" |
|Critério de Êxito | - Os dados inseridos do filtro de pesquisa devem mostrar corretamente os restaurantes/mercados filtrados. |


 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
