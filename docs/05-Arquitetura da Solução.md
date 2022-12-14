# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t3-mundo-veg/blob/main/docs/04-Projeto%20de%20Interface.md"> Projeto de Interface</a></span>

A arquitetura da solução apresenta como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas.
<figure>
  <img src="https://user-images.githubusercontent.com/100734910/201675204-c659cedb-1304-48ed-8abc-083fba9f69b6.png"
          <figcaption>Figura 17 - Diagrama de classes</figcaption>
<figure>

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades se relacionam entre si na aplicação interativa.

<figure>
  <img src="https://user-images.githubusercontent.com/100447878/205713498-b83bcf44-ecec-4218-bba1-ebab8c1f86a0.png"
  <figcaption>Figura 18 - Modelo Entidade Relacionamento</figcaption>
<figure>

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
  
<figure>
  <img src="https://user-images.githubusercontent.com/100447878/205713628-610e4b38-5392-4d05-90ca-6cba6101bcca.png"
  <figcaption>Figura 19 - Projeto da Base de Dados</figcaption>
<figure>

## Tecnologias Utilizadas
  
As tecnologias listadas abaixo serão utilizadas para a implementação da solução.

* Microsoft Visual Studio 2022
- Microsoft Visual Studio Code                                                                                                                  
* ASPNET Core 6.0                                                                                                               
- Database MSSQL
* Figma
- Lucid App
                                                                                                   
<h3>Interação do usuário com o sistema</h3>

A figura abaixo exemplifica como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

<figure>
  <img src="https://user-images.githubusercontent.com/100447878/194180197-7481ae69-650a-40c2-9e47-e9c12e9debec.gif" style="width:80%";
  <figcaption>Figura 20 - Interação do usuário com o sistema</figcaption>
<figure>
<br>
<br>
<p>Fonte: INTRODUCTION to the server side. <b>MDN web docs</b>, 9 set. 2022. Disponível em: https://developer.mozilla.org/en-US/docs/Learn/Server-side/First_steps/Introduction. Acesso em: 04 out. 2022.
  
## Hospedagem
A aplicação interativa foi hospedada em SmarterASP.NET com database MSSQL, através da opção Publish do Microsoft Visual Studio 2022. Para ter acesso a aplicação, <a href="http://daianecampos-001-site1.itempurl.com/">clique aqui.</a>
  <figure>
    <img src="https://user-images.githubusercontent.com/100447878/205776031-43b0d459-1044-4c69-9cc1-981db61a382a.png";
    <figcaption>Figura 21 - Hospedagem da aplicação</figcaption>
<figure>
