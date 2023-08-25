using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using PROJETOMVC.Models;
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

        public IActionResult List(string categoria)
        {
            ////var lanches = _lunchRepository.Lanches;
            ////return View(lanches);

            ////iremos utilizar viewmodel para que possamos pegar e exibir somente os dados necessários
            ////iremo instanciar a classe da viewmodel
            //var lunchListViewModel = new LunchListViewModel();
            ////usamos a instancia que possui uma lista do tipo lanches e adicionamos os lanches de _lunchRepository nela
            //lunchListViewModel.Lanches = _lunchRepository.Lanches;
            ////setamos a categoria também
            //lunchListViewModel.CategoriaAtual = "categoriaaaaakkkkkkkkkk";

            ////com a view model nós unimos somente as propriedade que vamos usar do lanche e categoria
            ////passamos para a view

            IEnumerable<Lunch> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lunchRepository.Lanches.OrderBy(x => x.LunchId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                //if (string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                //{
                //    lanches = _lunchRepository.Lanches.Where(x => x.Category.Name == "Normal" ).OrderBy(x => x.Name);

                //}
                //else if(string.Equals("Natural", categoria, StringComparison.OrdinalIgnoreCase))
                //{
                //     lanches = _lunchRepository.Lanches.Where(x => x.Category.Name == "Natural").OrderBy(x => x.Name);
                //}
                //else
                //{
                //    throw new Exception("A categoria informada não existe");

                //aqui usamos uma lógica melhor para filtrar os lanches, basicamente caso a categoria seja diferente de null iremos retornar todo os lanches da categoria passada
                lanches = _lunchRepository.Lanches.Where(x => x.Category.Name.Equals(categoria)).OrderBy(x => x.Name);
            }

            var lanchesListViewModel = new LunchListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoria,
            };


            return View(lanchesListViewModel);
        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Lunch> lanches;
            string categoriaAtual = string.Empty;
            
            //se o search for vazio ele retorna todos os lanches
            if (string.IsNullOrEmpty(searchString))
            {
                lanches = _lunchRepository.Lanches.OrderBy(x => x.LunchId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                //caso tenha algo escrito iremos verificar em quais lanches essa sequencia de caracteres aparece e retornar eles
                //caso nenhum tenha os caracteres iremos avisar que não contem lanches
                lanches = _lunchRepository.Lanches.Where(l => l.Name.ToLower().Contains(searchString.ToLower()));
                if(lanches.Any())
                {
                    categoriaAtual = "lanches!";
                }
                else
                {
                    categoriaAtual = "Não encontrado!";
                }
            }

            //podemos retornar uma view diferente de deste método, mas alterando os valores que ela recebe
            return View("~/Views/Lanche/List.cshtml", new LunchListViewModel
            {
                CategoriaAtual = categoriaAtual,
                Lanches = lanches

            });
        }

        public ActionResult Details(int lunchId) 
        {
            var repository = _lunchRepository;
            Lunch lanche = repository.Lanches.FirstOrDefault(l => l.LunchId == lunchId);
            return View(lanche);
        }
    }
}

