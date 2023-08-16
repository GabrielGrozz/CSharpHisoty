using PROJETOMVC.Context;
using PROJETOMVC.Models;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categorias => _context.Categories;
    }
}
