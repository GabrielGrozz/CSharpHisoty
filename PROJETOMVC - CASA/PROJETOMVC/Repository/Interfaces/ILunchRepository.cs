using PROJETOMVC.Models;

namespace PROJETOMVC.Repository.Interfaces
{
    public interface ILunchRepository
    {
        public IEnumerable<Lunch> Lanches { get; }
        public IEnumerable<Lunch> LanchesPreferidos { get; }
        public Lunch GetLancheByID(int LancheID);
    }
}
