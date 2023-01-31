using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

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
            var movies = _dbContext.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            var movie = _dbContext.Movies.Include(m => m.Genre).FirstOrDefault(x => x.Id == id);
            return View(movie);
        }
        public IActionResult New(int? id)
        {
            var viewModel = new MovieFormViewModel() { Genres = _dbContext.Genres.ToList(), Movie = new Movie() };
            if (id != null)
                viewModel.Movie = _dbContext.Movies.Include(m => m.Genre).Single(x => x.Id == id);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _dbContext.Genres.ToList()
                };

                return View("New", viewModel);
            }
            if (movie.Id == 0)
            {
                _dbContext.Add(movie);
            }
            else
            {
                var movieInDatabase = _dbContext.Movies.Single(m => m.Id == movie.Id);
                movieInDatabase.Name = movie.Name;
                movieInDatabase.Release = movie.Release;
                movieInDatabase.Stock = movie.Stock;
                movieInDatabase.GenreId = movie.GenreId;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}
