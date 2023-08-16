using Microsoft.AspNetCore.Mvc;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILunchRepository _repository;

        public LancheController(ILunchRepository repository)
        {
            _repository = repository;
        }

        public IActionResult List()
        {
            var lanches = _repository.Lanches;
            return View(lanches);
        }
    }
}
