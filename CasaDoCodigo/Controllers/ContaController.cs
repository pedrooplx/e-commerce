using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class ContaController : Controller
    {
        [Authorize]
        public async Task<IActionResult> Login()
        {
            return Redirect(Url.Content("~/")); //"~/" para ir para a HomePage
        }
        
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("Cookies"); //Serve para atualizar os cookies de sessão (autenticação local)
            await HttpContext.SignOutAsync("OpenIdConnect"); //Serve para desconectar o usuário no IdentityServer
            return Redirect(Url.Content("~/"));
        }
    }
}
