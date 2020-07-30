using E_Commerce.Models;
using E_Commerce.Repository;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace E_Commerce
{
    public partial class Startup
    {
        //Classe para alimentar o banco de dados com o catalogo inicial dos produtos e garantir que tenha sido criado
        class DataService : IDataService
        {
            private readonly ApplicationContext context;
            private readonly IProdutoReposiory produtoReposiory;

            public DataService(ApplicationContext context, IProdutoReposiory produtoReposiory)
            {
                this.context = context;
                this.produtoReposiory = produtoReposiory;
            }

            public void InicializaDB()
            {
                context.Database.EnsureCreated();

                //Lendo arquivo JSON e gravando no banco de dados
                List<Livro> livros = GetLivros();

                produtoReposiory.SaveProdutos(livros);
            }

            private static List<Livro> GetLivros()
            {
                var json = File.ReadAllText("livros.json");
                var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
                return livros;
            }
        }
    }
}