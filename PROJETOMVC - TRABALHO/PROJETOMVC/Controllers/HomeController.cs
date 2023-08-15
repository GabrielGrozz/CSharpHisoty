using Microsoft.AspNetCore.Mvc;
using PROJETOMVC.Models;
using System.Diagnostics;

namespace PROJETOMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //essa seria uma tempdata, podemos definila em um controlador diferente e acessar ele em outra view diferente da home, mas
            //é necessário acessar a view onde o tempdata esta setado antes, pois ele é removido automaticamente após o valor ser recuperado
            TempData["valortemp"] = "para isso aparecer precisa ser acessado o home antes";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}