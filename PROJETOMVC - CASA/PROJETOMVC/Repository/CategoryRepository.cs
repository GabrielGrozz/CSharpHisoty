using PROJETOMVC.Context;
using PROJETOMVC.Models;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        //aqui criamos uma instancia de AppDbContext, pois é ele que "tem acesso" ao banco de dados,
        private readonly AppDbContext _context;


        //aqui simplesmente definimos um construtor onde podemos passar nossa instancia de AppDbContext
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        //esse seria a propriedade que setamos na interface,
        public IEnumerable<Category> Categorias => _context.Categories; // --expression bodied member
    }
}
