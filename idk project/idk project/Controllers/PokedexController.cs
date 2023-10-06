using Microsoft.AspNetCore.Mvc;
using PokeApiNet;

namespace idk_project.Controllers
{
    public class PokedexController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var Client = new PokeApiClient();
            Pokemon Hoho = await Client.GetResourceAsync<Pokemon>("ho-ho");
            Console.WriteLine(Hoho);
            return View(Hoho);
        }

    }
}
