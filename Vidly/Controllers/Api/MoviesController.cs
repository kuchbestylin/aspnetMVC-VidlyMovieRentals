using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.Dtos;
using Vidly.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public MoviesController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<MovieDto>> GetMovies()
        {
            return Ok(_dbContext.Movies.Select(_mapper.Map<Movie, MovieDto>));
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id:int}", Name = "GetMovie")]
        public IActionResult GetMovie(int id)
        {
            var movie = _dbContext.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null) return NotFound();

            return Ok(_mapper.Map<Movie, MovieDto>(movie));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] MovieDto movieDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var movie = _mapper.Map<MovieDto, Movie>(movieDto);

            _dbContext.Add(movie);

            _dbContext.SaveChanges();

            movieDto.Id = movie.Id;

            return CreatedAtRoute("GetMovie", new { id = movieDto.Id }, movieDto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult PutMovie(int id, [FromBody] MovieDto movieDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var movieInDb = _dbContext.Movies.SingleOrDefault(m => m.Id == id);
            int y = 0;
            if (movieInDb == null) return NotFound();
            _mapper.Map(movieDto, movieInDb);

            _dbContext.SaveChanges();

            return Ok(_mapper.Map<Movie, MovieDto>(movieInDb));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movieInDb = _dbContext.Movies.Single(m => m.Id == id);

            if (movieInDb == null) return NotFound();

            _dbContext.Remove(movieInDb);

            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}
