using E_Commerce.Models;
using System.Collections.Generic;

namespace E_Commerce.Repository
{
    public interface IProdutoReposiory
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}