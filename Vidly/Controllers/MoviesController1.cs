using Microsoft.AspNetCore.Mvc;

namespace Vidly.Controllers
{
    public class MoviesController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
