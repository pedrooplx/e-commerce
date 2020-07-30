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
        private readonly IPedidoRepository pedidoRepository;

        public PedidoController(IProdutoReposiory produtoReposiory, IPedidoRepository pedidoRepository) /*Passando repositórios via injeção de dependência*/
        {
            this.produtoReposiory = produtoReposiory;
            this.pedidoRepository = pedidoRepository;
        }
        public IActionResult Carrossel()
        {
            return View(produtoReposiory.GetProdutos());
        }
        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                pedidoRepository.AddItem(codigo);
            }

            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido.Itens);
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Resumo()
        {
            return View();
        }
    }
}
