using PROJETOMVC.Models;

namespace PROJETOMVC.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Categorias { get; }
    }
}
