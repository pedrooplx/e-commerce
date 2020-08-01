using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using E_Commerce.Models;
using E_Commerce.Repository;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using E_Commerce.Models.ViewModels;

namespace E_Commerce.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoReposiory produtoReposiory;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IItemPedidoRepository itemPedidoRepository;

        public PedidoController(IProdutoReposiory produtoReposiory, IPedidoRepository pedidoRepository, IItemPedidoRepository itemPedidoRepository) /*Passando repositórios via injeção de dependência*/
        {
            this.produtoReposiory = produtoReposiory;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
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

            List<ItemPedido> itens = pedidoRepository.GetPedido().Itens;
            CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itens);
            return base.View(carrinhoViewModel);
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Resumo()
        {
            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido);
        }

        [HttpPost]
        public void UpdateQuantidade([FromBody] object model) //FromBody serve para haver a possibilidade de enviar os dados da View para o Controller
        {
            string serialize = JsonSerializer.Serialize(model);
            var item = Regex.Replace(serialize, "[^0-9,]+", "").Split(',');

            ItemPedido itemPedido = new ItemPedido();
            itemPedido.AttrDados(int.Parse(item[0]), int.Parse(item[1]));

            itemPedidoRepository.UpdateQuantidade(itemPedido);
        }
    }
}
