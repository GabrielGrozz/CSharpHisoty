using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using PROJETOMVC.Repository;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILunchRepository _lunchRepository;

        public LancheController(ILunchRepository lunchRepository)
        {
            _lunchRepository = lunchRepository;
        }

        public IActionResult List()
        {
            //view data/bag para exemplo na aplicação, elas são perdidas na
            //aqui temos a viewdata, ela requer uma conversão de tipos
            ViewData["nome"] = "Gabriel Grózz";
            //aqui temos a viewbag, ela não requer uma conversão de tipos
            ViewBag.numero = "42208922";

            var lanches = _lunchRepository.Lanches;
            return View(lanches);
        }
    }
}
