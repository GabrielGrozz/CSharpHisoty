using Microsoft.EntityFrameworkCore;
using PROJETOMVC.Context;
using PROJETOMVC.Models;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC.Repository
{
    //classe repository para termos acesso aos dados dos lanches do banco
    public class LunchRepository : ILunchRepository
    {
        //variavel com a instancia do nosso contexto
        private readonly AppDbContext _context;

        //implementação de uma DI do contexto pelo contrutor
        //quem está nos passando esse parametro do contrutor é o container de DI nativo do ASP.NET, com ele podemos ter acesso ao contexto sem precisarmos passar explicitamente ele
        //para que isso funcione devemos configurar quais classes terão acesso ao nosso contexto  nos services.
        public LunchRepository(AppDbContext context)
        {
            _context = context;
        }

        //o include serve para que tenhamos a classe categoria do lanche
        public IEnumerable<Lunch> Lanches => _context.Lunchs.Include(e => e.Category);

        public IEnumerable<Lunch> LanchePreferidos => _context.Lunchs.Where(e => e.Preferred).Include(e => e.Category);

        public Lunch GetLunchById(int id)
        {
            return _context.Lunchs.FirstOrDefault(e => e.LunchId == id);
        }
    }
}
