using PROJETOMVC.Models;

namespace PROJETOMVC.Repository.Interfaces
{
    //essa será a nossa interface para podermos acessarmos a tabela de categorias do nosso banco
    public interface ICategoryRepository
    {
        //ela terá uma propiedade somente leitura
        public IEnumerable<Category> Categorias { get; }
    }
}
