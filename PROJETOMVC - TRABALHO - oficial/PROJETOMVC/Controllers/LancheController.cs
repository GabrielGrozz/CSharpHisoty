using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using PROJETOMVC.Repository;
using PROJETOMVC.Repository.Interfaces;
using PROJETOMVC.ViewModels;

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
            //var lanches = _lunchRepository.Lanches;
            //return View(lanches);

            //iremos utilizar viewmodel para que possamos pegar e exibir somente os dados necessários
            //iremo instanciar a classe da viewmodel
            var lunchListViewModel = new LunchListViewModel();
            //usamos a instancia que possui uma lista do tipo lanches e adicionamos os lanches de _lunchRepository nela
            lunchListViewModel.Lanches = _lunchRepository.Lanches;
            //setamos a categoria também
            lunchListViewModel.CategoriaAtual = "categoriaaaaakkkkkkkkkk";

            //com a view model nós unimos somente as propriedade que vamos usar do lanche e categoria
            //passamos para a view
            return View(lunchListViewModel);
        }
    }
}
