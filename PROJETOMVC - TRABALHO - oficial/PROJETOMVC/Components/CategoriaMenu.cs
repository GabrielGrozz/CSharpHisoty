using Microsoft.AspNetCore.Mvc;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoryRepository _context;
        public CategoriaMenu(ICategoryRepository context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        {
            var categorias = _context.Categorias.OrderBy(x => x.Name);
            return View(categorias);
        }
    }
}
