using PROJETOMVC.Models;

namespace PROJETOMVC.ViewModel
{
    public class LunchListViewModel
    {
        public IEnumerable<Lunch> lanches { get; set; }
        public string categoria { get; set; }
    }
}
