using PROJETOMVC.Models;

namespace PROJETOMVC.ViewModels
{
    //esse será a nossa view model
    public class LunchListViewModel
    {
        public IEnumerable<Lunch> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
