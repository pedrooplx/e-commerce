using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using E_Commerce.Models;

namespace E_Commerce.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Carrinho()
        {
            return View();
        }
        public IActionResult Carrossel()
        {
            return View();
        }
        public IActionResult Resumo()
        {
            return View();
        }
    }
}
