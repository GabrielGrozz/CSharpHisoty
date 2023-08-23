using Microsoft.AspNetCore.Mvc;

namespace PROJETOMVC.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return "--[testando a rota admin com a action index]--";
        }
        public string Demo()
        {
            return "--[testando a rota admin com a actiopn Demo]--";
        }
    }
}
