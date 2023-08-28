using LanchesMac.Models;
using Microsoft.AspNetCore.Mvc;
using PROJETOMVC.Repository.Interfaces;

namespace PROJETOMVC.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Pedido pedido) 
        { 
            return View();
        }
    }
}
