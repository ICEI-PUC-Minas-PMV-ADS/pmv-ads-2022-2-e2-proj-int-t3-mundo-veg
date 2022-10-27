# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t3-mundo-veg/blob/main/docs/04-Projeto%20de%20Interface.md"> Projeto de Interface</a></span>

A arquitetura da solução apresenta como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas.
<figure>
  <img src="https://user-images.githubusercontent.com/100734910/191252412-18dcc9ab-b8ff-4846-b29f-17a2d4e677de.png"
  <figcaption>Figura 16 - Diagrama de classes</figcaption>
<figure>

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades se relacionam entre si na aplicação interativa.

<figure>
  <img src="https://user-images.githubusercontent.com/100447878/197857395-25e439fe-5ab9-4dcc-a52f-ff8fc7767ff2.png"
  <figcaption>Figura 17 - Modelo Entidade Relacionamento</figcaption>
<figure>

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
  
<figure>
  <img src="https://user-images.githubusercontent.com/100447878/197856091-2cde72d3-1ed7-4627-8c4a-fd6d79dd9568.png"
  <figcaption>Figura 18 - Projeto da Base de Dados</figcaption>
<figure>

## Tecnologias Utilizadas

* Microsoft Visual Studio 2022
- Microsoft Visual Studio Code                                                                                                                  
* ASPNET Core 6.0                                                                                                               
- Database MSSQL
* Figma
                                                                                                   
<h3>Interação do usuário com o sistema</h3>

<figure>
  <img src="https://user-images.githubusercontent.com/100447878/194180197-7481ae69-650a-40c2-9e47-e9c12e9debec.gif" style="width:80%";
  <figcaption>Figura 19 - Interação do usuário com o sistema</figcaption>
<figure>
<br>
<br>
<p>Fonte: INTRODUCTION to the server side. <b>MDN web docs</b>, 9 set. 2022. Disponível em: https://developer.mozilla.org/en-US/docs/Learn/Server-side/First_steps/Introduction. Acesso em: 04 out. 2022.
  
## Hospedagem
Aplicação interativa hospedada em SmarterASP.NET com database MSSQL, através da opção Publish do Microsoft Visual Studio 2022. Para ter acesso a aplicação, <a href="http://gfaustini-001-site1.atempurl.com/">clique aqui.</a>
  <figure>
    <img src="https://user-images.githubusercontent.com/100742971/198089584-6167192b-8530-4426-8d08-548887240a76.png";
    <figcaption>Figura 20 - Hospedagem da aplicação</figcaption>
<figure>
