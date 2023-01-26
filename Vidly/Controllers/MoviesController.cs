using Microsoft.AspNetCore.Mvc;
using Vidly.Data;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public MoviesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var movies = _dbContext.Movies.ToList();
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            var movie = _dbContext.Movies.FirstOrDefault(x => x.Id == id);
            return View(movie);
        }
    }
}
