using Microsoft.EntityFrameworkCore;
using PROJETOMVC.Context;
using PROJETOMVC.Models;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC.Repository
{
    public class LunchRepository : ILunchRepository
    {
        private readonly AppDbContext _context;

        LunchRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lunch> Lanches => _context.Lunchs.Include(e => e.Category);

        public IEnumerable<Lunch> LanchesPreferidos => _context.Lunchs.Where(e => e.Preferred).Include(e => e.Category);

        public Lunch GetLancheByID(int id)
        {
            return _context.Lunchs.FirstOrDefault(e => e.LunchId == id);
        }
    }
}
