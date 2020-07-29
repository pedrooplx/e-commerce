using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class ProdutoReposiory : IProdutoReposiory
    {
        private readonly ApplicationContext context;

        public ProdutoReposiory(ApplicationContext context)
        {
            this.context = context;
        }

        public IList<Produto> GetProdutos()
        {
            return context.Set<Produto>().ToList();
        }

        public void SaveProdutos(List<Tenis> tenis)
        {
            foreach (var item in tenis)
            {
                context.Set<Produto>().Add(new Produto(item.Codigo, item.Nome, item.Preco));
            }
            context.SaveChanges();
        }
    }
    public class Tenis
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
