using PROJETOMVC.Models;

namespace PROJETOMVC.Repository.Interfaces
{
    public interface ILunchRepository
    {
        public IEnumerable<Lunch> Lanches { get; }
        public IEnumerable<Lunch> LanchePreferidos { get; }
        public Lunch GetLunchById(int id);
    }
}
