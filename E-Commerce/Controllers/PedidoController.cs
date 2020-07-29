using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using E_Commerce.Models;
using E_Commerce.Repository;

namespace E_Commerce.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoReposiory produtoReposiory;

        public PedidoController(IProdutoReposiory produtoReposiory)
        {
            this.produtoReposiory = produtoReposiory;
        }
        public IActionResult Carrossel()
        {
            return View(produtoReposiory.GetProdutos());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Carrinho(string codigo)
        {
            return View();
        }
        public IActionResult Resumo()
        {
            return View();
        }
    }
}
