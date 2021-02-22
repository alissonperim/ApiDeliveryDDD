# ApiDeliveryDDD

- A aplicação é responsável pro registrar entregas, contendo nesse registro:
  * Empresa responsável pela entrega;
  * Entregador;
  * Cliente;
  * Data e hora do registro da entrega;
  * Status da entrega.
- Possui CRUD (Creat, Read, Update e Delete) para cada uma das entidades do projeto.
- O ApiDeliveryDDD está sendo construído utilizando linguagem C#, .Net Core e Entity Framework.
- A API nasceu com a necessidade particular minha de evoluir meus conhecimentos em C#, .Net Core, Entity Framework e DDD (Domain Driven Design).
- Para iniciar a aplicação é necessário seguir os seguintes passos:
  * É necessário ter instalado no computador o software Visual Studio, [fazer download](https://visualstudio.microsoft.com/pt-br/downloads/);
  * Faça o clone do projeto para a sua máquina, [clonar](https://github.com/alissonperim/ApiDeliveryDDD), clique em Code e depois em Download Zip,
  extraia o projeto do arquivo Zip para uma pasta.
  * Quando terminar a instalação abra o Visual Studio, clique em Open a project or solution, selecione a pasta onde foi extraído o arquivo Zip,
  encontre o arquivo chamado ApiDeliveryDDD.sln e clique duas vezes sobre ele;
  * O projeto abrirá, no topo da janela, procure o ícone de uma seta verde, clique nele, será aberto uma página do seu navegador, com o diretório
  do swagger, nessa página haverá alguns tópicos:
    * Client;
    * Companies;
    * Deliveries;
    * Employees;
  * Dentro de cada tópico há alguns sub-tópicos chamados:
    * Post;
    * Put;
    * Get;
    * Get/id;
    * Delete;
  * O sub-tópico Post é responsável pelo cadastro de cada tópico;
  * O sub-tópico Put é responsável pela atualização de cada tópico;
  * O sub tópico Get é responsável pelo retorno de todos os cadastros;
  * O sub-tópico Get/id é responsável pelo retorno de um cadastro, onde id é o dado passado para busca;
  * O sub-tópico Delete é responsável por deletar o cadastro.
