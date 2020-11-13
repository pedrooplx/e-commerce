# E-Commerce
Desenvolvimento de software de comércio eletrônico no curso [ASP.NET Core - Alura](https://cursos.alura.com.br/course/aspnet-core-2-validacoes-seguranca), visando aperfeiçoar minhas habilidades back-end, boas práticas, conhecimentos práticos sobre design patterns e aprender mais sobre algumas das tecnologias mais usadas no mercado atual.

Tambem foi desenvolvido uma API para gerar relatório de vendas, podemos acompanhar esse relatório entrando no servidor local em que a API está localizada e atualizando a página assim que algum pedido for finalizado no e-commerce.

### Imagens:
![ezgif-3-3dcbf920a015](https://user-images.githubusercontent.com/56414441/99114101-0f4b8e80-25cf-11eb-9d4c-548182dd1ad5.gif)

### Alguns dos principais objetivos deste desenvolvimento:
- Usar a última versão da plataforma web usada, .Net Core;
- Desenvolvimento com código cross plataforma, Windows, Linux e Mac OS;
- Desenvolvimento de websites prontos para a nuvem;
- Arquitetura MVC, o padrão mais utilizado para desenvolvimento web;
- Conteúdo dinâmico com Razor, View Engine e Tag Helpers;
- Configuração do Entity Framework Core e migrations para criação e gestão do bancos de dados, SQL Server/SQLite;
- Organização do código JavaScript com classes e métodos;
- Data Contract para que dados do modelo trafeguem do cliente para o servidor, e vice-versa;
- Reforço da segurança da aplicação web com Identity/IdentityServe 4 e Token Anti-Falsificação.

### Características

| Característica  |  Codificado?       | Descrição  |
|----------|:-------------:|:-------------|
| Lista de produtos | &#10004; | Capacidade de lista de produtos |
| Adicionar um produto	 | &#10004; | Capacidade de adicionar um produto ao sistema |
| Crie um carrinho | &#10004; | Capacidade de criar um novo carrinho |
| Ver carrinho | &#10004; | Capacidade de ver o carrinho e seus itens |
| Remover um carrinho | &#10004; | Capacidade de remover um carrinho |
| Adicionar Item | &#10004; | Capacidade de adicionar um novo item no carrinho |
| Alterar Item | &#10004; | Capacidade de alterar quantidade de um item do carrinho |
| Remover um Item | &#10004; | Capacidade de remover um item do carrinho |

### Tecnologias usadas
* [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) - Framework para sistemas operacionais Windows, Linux e macOS.
* [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/) - Framework multiplataforma de acesso a dados do Entity Framework.
* [ASP.NET Identity](https://docs.microsoft.com/pt-br/aspnet/identity/) - API que dá suporte à funcionalidade de logon da interface do usuário e gerencia usuários, senhas, dados de perfil, funções, declarações, tokens, confirmação por email, etc.
* [Identity Server 4](https://identityserver4.readthedocs.io/en/latest/) - Básicamente, um Identity para arquitetura micro-services com estrutura OpenID Connect e OAuth 2.0.
* [JWT](https://jwt.io/) - JSON Web Token para a criação de dados com assinatura e criptografia.
* [Bootstrap](https://getbootstrap.com/) - Framework web para desenvolvimento e front-end.
* [jQuery](https://jquery.com/)- Biblioteca de funções JavaScript para interação com o HTML.
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/) - Banco de dados para regras de negócio.
* [SQLite](https://www.sqlite.org/index.html) - Banco de dados para gestão de usuário (Identity/Identity Server).

### Instalação e execução
O primeiro passo é ter o [Microsoft .Net Core SDK 2.2](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.204-windows-x86-installer) instalado em sua máquina.

Após instalação do SDK, decida qual a versão deseja instalar, pois neste projeto temos a versão com Identitye Identity Server em arquitetura micro-services.

→ Baixar versão com [Identity](https://github.com/pedrooplx/e-commerce/tree/a85c420dd43724bf626e5fc97dcc0f08ff500d9d)
→ Baixar versão com [Identity Server 4 - Microservices](https://github.com/pedrooplx/e-commerce/tree/3295981d1ec062ff76314ab651c47d6a17a41299).

Após o download, abra o arquivo .sln no Visual Studio, [compile e limpe](https://docs.microsoft.com/pt-br/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2019) a solução e em seguida, "F5" para rodar o projeto.

Assim que o projeto carregar, você pode usar sua conta Google ou Microsoft para entrar e efetuar um pedido ou criar uma conta pelo próprio software.

#### Erro
Caso apresente o seguinte erro "RazorTagHelper Task failed unexpectedly" ao compilar a solução, não se preocupe pois, é algo referênte à uma atualização do .Net Core SDK 2.2.
Portanto, siga [essas](https://github.com/dotnet/sdk/issues/14497#issuecomment-725196698) instruções para contornarmos este problema.

Para qualquer dúvida ou problema, entre em contato comigo clicando [aqui](https://linktr.ee/pedrooplx).

