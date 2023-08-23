using Microsoft.AspNetCore.Mvc;

namespace PROJETOMVC.Controllers
{
    public class TesteControler : Controller
    {
        public string Index()
        {
            return "--[testando a rota de TESTE]--";
        }
    }
}
