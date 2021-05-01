# Crud MVC API Dotnet com Specflow/Selenium
Este repositório contém uma solução .NET Core com projetos MVC e API. Ele também tem uma solução de teste de unidade usando Specflow e Selenium. Para obter mais informações, verifique o arquivo README.

- Solução CrudMvcDotnet
  
   Esta solução .NET inclui exemplos de projetos MVC e API. O CRUD é uma tela simples de registro do produto e suas categorias.
   O banco de dados do sistema é o SQL Server. O EntityFramework é usado no projeto, bem como as migrations.
   Pacotes Nuget usados:
    - MVC: Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools. 
    - API: Microsoft.EntityFrameworkCore.Tools, Swashbuckle.AspNetCore (Swagger optional)
    
- Solução CrudMvcDotnetSpec

  Esta solução .NET inclui um exemplo de estrutura de teste de unidade com Specflow e Selenium.
  Pacotes Nuget usados: Selenium (Support, WebDriver, WebDriver.ChromeDriver), Specflow, Specflow.MsTest
  
- Para executar o projeto MVC na solução CrudMvcDotnet, você inicia a aplicação acessando a porta presente na propriedade do projeto no navegador.
- Para executar o projeto de API na solução CrudMvcDotnet, você inicia a aplicação e verifica usando Swagger ou Postman.
- Para executar o projeto de teste na solução CrudMvcDotnetSpec, você inicia a aplicação MVC CrudMvcDotnet e executa os testes no explorer.
  
 
  
