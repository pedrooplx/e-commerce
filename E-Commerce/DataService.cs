using E_Commerce.Models;
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

            public DataService(ApplicationContext context)
            {
                this.context = context;
            }

            public void InicializaDB()
            {
                context.Database.EnsureCreated();

                //Lendo arquivo JSON e gravando no banco de dados
                var json = File.ReadAllText("tenis.json");
                var tenis = JsonConvert.DeserializeObject<List<Tenis>>(json);

                foreach (var item in tenis)
                {
                    context.Set<Produto>().Add(new Produto(item.Codigo, item.Nome, item.Preco));
                }
                context.SaveChanges();
            }
        }

        class Tenis
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }
    }
}
