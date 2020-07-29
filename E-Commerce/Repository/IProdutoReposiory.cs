using E_Commerce.Models;
using System.Collections.Generic;

namespace E_Commerce.Repository
{
    public interface IProdutoReposiory
    {
        void SaveProdutos(List<Tenis> tenis);
        IList<Produto> GetProdutos();
    }
}