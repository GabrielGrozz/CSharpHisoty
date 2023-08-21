using Microsoft.AspNetCore.Mvc;
using PROJETOMVC.Models;
using PROJETOMVC.ViewModels;
using PROJETOMVC.Repository.Interfaces;
using System.Diagnostics;

namespace PROJETOMVC.Controllers
{
    public class HomeController : Controller
    {

        //sempre que for preciso acessar o banco, precisamos utilizar uma instancia do repositório, pois ele tem acesso ao banco
        //instancia da repositorio
        private readonly ILunchRepository _LancheRepository;
        public HomeController(ILunchRepository repository)
        {
            _LancheRepository = repository;
        }

        public IActionResult Index()
        {   //instancia da viewmodel
            var lanchesPreferidos = new HomeViewModel
            {
                Preferidos = _LancheRepository.LanchePreferidos
            };

            return View(lanchesPreferidos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}