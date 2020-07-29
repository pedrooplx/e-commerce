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
                List<Tenis> tenis = GetTenis();

                if (produtoReposiory.GetProdutos().Count == 0)
                {
                    produtoReposiory.SaveProdutos(tenis);
                }
            }

            private static List<Tenis> GetTenis()
            {
                var json = File.ReadAllText("tenis.json");
                var tenis = JsonConvert.DeserializeObject<List<Tenis>>(json);
                return tenis;
            }
        }
    }
}
