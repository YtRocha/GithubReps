using Microsoft.AspNetCore.Mvc;

namespace GithubReps.Controllers
{
    public class Favoritos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
