using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public class ProdutoReposiory : BaseRepository<Produto>, IProdutoReposiory
    {
        public ProdutoReposiory(ApplicationContext context) : base(context)
        {
        }

        public IList<Produto> GetProdutos()
        {
            return dbSet.ToList();
        }

        public void SaveProdutos(List<Tenis> tenis)
        {
            foreach (var item in tenis)
            {
                if (!dbSet.Where(p => p.Codigo == item.Codigo).Any())
                {
                    dbSet.Add(new Produto(item.Codigo, item.Nome, item.Preco));
                }
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
