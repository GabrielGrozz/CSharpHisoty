using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            //ViewData seria como se fosse um props do react/vue, mas diferente, podemos acessar os viewdatas no nossa 
            //view atraves do @viewdata["nome da viewdata"]
            ViewData["Message"] = "Your application description page.";

            //o método View seria oq chamamos método auxiliar, um metohd builder, ele retorna um IActionResult, que seria
            //um método auxiliar
            //quando retornamos um View, com isso o framework irá procurar na
            //pasta Views, na rota Home/About(que é aonde estamos)
            //--segue na pagina about
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Foda()
        {
            ViewData["first"] = "HELLO WORLD!";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
