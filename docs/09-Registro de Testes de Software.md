# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t3-mundo-veg/blob/main/docs/04-Projeto%20de%20Interface.md"> Projeto de Interface</a>, <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t3-mundo-veg/blob/main/docs/08-Plano%20de%20Testes%20de%20Software.md"> Plano de Testes de Software</a></span>

Neste etapa foram realizados os testes referentes ao cadastro de usuários, estabelecimentos, receitas e produtos; o gerenciamento da conta e o login. 

|Caso de teste    | Requisito Associado  | Registro de teste |
|------|-----------------------------------------|----|
|CT-01 – Cadastrar perfil de usuário| RF-001 - A aplicação interativa deve permitir ao usuário cadastrar uma conta. | <a href="https://user-images.githubusercontent.com/100734910/206000402-ba8155aa-f1f0-47ba-81a9-13f520223b4d.mp4">Clique aqui para ver o vídeo</a>  | 
|CT-02 – Cadastrar estabelecimentos| RF-002 - A aplicação interativa deve permitir aos donos de restaurantes e mercados cadastrar uma conta com informações sobre o estabelecimento. | <a href="https://user-images.githubusercontent.com/100734910/206016766-f870c2c2-16d9-4769-a8af-64a109e4e106.mp4">Clique aqui para ver o vídeo</a>  | 
|CT-03 – Efetuar login| RF-003 - A aplicação interativa deve permitir ao usuário cadastrado fazer o login da sua conta.  | <a href="https://user-images.githubusercontent.com/100734910/206018553-6934b395-ba5d-4fa9-9d58-417e1ea5d402.mp4">Clique aqui para ver o vídeo</a>  |
|CT-04 – Filtro/pesquisa de produtos e receitas| RF-004 - A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar produtos e receitas.  | <a href="https://user-images.githubusercontent.com/100734910/206261512-d20f83a6-5ac2-4a8f-8b30-c5576e97d559.mp4">Clique aqui para ver o vídeo</a>|
|CT-05 – Filtro/pesquisa de restaurantes e mercados| RF-005 - A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar restaurantes e mercados vegetarianos e veganos. | <a href="https://user-images.githubusercontent.com/98122346/206277802-40e04475-4c2a-4c40-a9cf-25cd7fa52d51.mp4">Clique aqui para ver o vídeo</a>|
|CT-06 – Filtro/pesquisa de receitas através de ingredientes| RF-006 - A aplicação interativa deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário pesquisar receitas através de ingredientes específicos.  | <a href="https://user-images.githubusercontent.com/98122346/206277947-50fdfce8-ac52-4b34-aebe-d2cb063f726e.mp4">Clique aqui para ver o vídeo</a>|
|CT-07 – Visualizar informações dos estabelecimentos| RF-007 - A aplicação interativa deve permitir ao usuário visualizar as informações de contato dos estabelecimentos.  | <a href="https://user-images.githubusercontent.com/98122346/206278056-32a7fa10-4407-4f14-adfe-a38723b50c07.mp4">Clique aqui para ver o vídeo</a>|
|CT-08 – Contactar os estabelecimentos através do WhatsApp| RF-008 A aplicação interativa deve permitir ao usuário entrar em contato com os estabelecimentos.  | <a href="https://user-images.githubusercontent.com/98122346/206278140-7ba079f0-66eb-4208-8df8-44e1a0e3000a.mp4">Clique aqui para ver o vídeo</a>|
|CT-09 – Cadastrar receitas| RF-009 - A aplicação interativa deve permitir o cadastro de receitas pelos usuários logados na plataforma.  | <a href="https://user-images.githubusercontent.com/100742971/206867089-a7b7ce47-dba9-483d-b96c-6948723886b4.mp4">Clique aqui para ver o vídeo</a>  |
|CT-10 – Gerenciar conta| RF-010 - A aplicação interativa deve permitir ao usuário gerenciar a sua conta (Clientes). | <a href="https://user-images.githubusercontent.com/100742971/206868450-6e0a5c2c-e6a8-4912-a1f0-baf9189329bf.mp4">Clique aqui para ver o vídeo</a>  |
|CT-10 – Gerenciar conta| RF-010 - A aplicação interativa deve permitir ao usuário gerenciar a sua conta (Estabelecimentos). | <a href="https://user-images.githubusercontent.com/100447878/206904654-a6d4fc72-c988-4d6f-830e-5c306ce21378.mp4">Clique aqui para ver o vídeo</a> |
|CT-11 – Cadastrar produtos| RF-011 - A aplicação interativa deve permitir o cadastro de produtos pelos estabelecimentos logados na plataforma. | <a href="https://user-images.githubusercontent.com/100742971/206869297-4e27fb0c-ef15-4651-b31e-c2194469836d.mp4">Clique aqui para ver o vídeo</a>  |

## Avaliação

Os testes foram realizados e os requisitos funcionais foram atendidos.

No planejamento inicial do projeto, os usuários da aplicação interativa poderiam cadastrar uma imagem ao cadastrar um estabelecimento, receita ou produto. Porém, devido a dificuldades na programação, a ideia inicial foi alterada e uma imagem padrão é registrada com cada cadastro de estabelecimento, receita e produto.

O erro no cadastro da imagem, como mostrado abaixo, acontecia de forma aleatória, o que dificultou o entendimento do problema pelo grupo:

Vídeo 1: registro da imagem com sucesso

https://user-images.githubusercontent.com/100447878/206047528-9680bb2d-fef7-4b5a-b986-01b6a65c8d42.mp4

Vídeo 2: registro da imagem com erro

https://user-images.githubusercontent.com/100447878/206047923-9b5fcd03-81a6-4edc-9e27-73cdc31033ec.mp4

A branch "daiane" possui o código utilizado para a implementação dessa funcionalidade.
