using Microsoft.EntityFrameworkCore;
using PROJETOMVC.Context;

namespace PROJETOMVC.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;

        //aqui não precisamos definir o acesso do context pois estamos fazendo o acesso dentro da pasta models e não em um repositório
        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        // o id será uma GUID
        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        //esse será o método que irá nos retornar o nosso carrinho de compra, passamos como parametro um IServiceProvider, que será usado para definir a session
        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            //definimos uma session, caso a session ja exista, usar ela
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //pegamos um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            session.SetString("CarrinhoId", carrinhoId);

            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId,
            };


        }

        public void AdicionarAoCarrinho(Lunch lanche)
        {
            //verifica se o carrinho existe ou não
            var carrinhoCompraItem = _context.carrinhoCompraItens.SingleOrDefault(e => e.Lanche.LunchId == lanche.LunchId && e.CarrinhoCompraId == CarrinhoCompraId);

            //se o carrinho não existir
            if (carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };
                _context.carrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }

            _context.SaveChanges();
        }

        public int RemoverdoCarrinho(Lunch lanche)
        {
            var carrinhoCompraItem = _context.carrinhoCompraItens.SingleOrDefault(e => e.Lanche.LunchId == lanche.LunchId && e.CarrinhoCompraId == CarrinhoCompraId);

            int qunatidadeLocal = 0;

            if (carrinhoCompraItem.Quantidade > 1)
            {
                carrinhoCompraItem.Quantidade--;
                qunatidadeLocal = carrinhoCompraItem.Quantidade;

            }
            else
            {
                _context.carrinhoCompraItens.Remove(carrinhoCompraItem);
            }
            _context.SaveChanges();
            return qunatidadeLocal;
        }

        public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
        {
            return CarrinhoCompraItens ?? (CarrinhoCompraItens =
                _context.carrinhoCompraItens.Where(c => c.CarrinhoCompraId == CarrinhoCompraId).Include(s => s.Lanche).ToList());

        }

        public void LimparCarrinho()
        {
            var carrinhoItens = _context.carrinhoCompraItens.Where(x => x.CarrinhoCompraId == CarrinhoCompraId);

            _context.carrinhoCompraItens.RemoveRange(carrinhoItens);

            _context.SaveChanges();
        }

        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.carrinhoCompraItens.Where(x => x.CarrinhoCompraId == CarrinhoCompraId)
                .Select(x => x.Lanche.Price).Sum();
            return total;
        }

    }
}
