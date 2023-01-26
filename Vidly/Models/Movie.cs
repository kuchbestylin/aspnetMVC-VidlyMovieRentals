using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Required]
        public DateTime? Release { get; set; }
        [Required]
        public DateTime? Added { get; set; }
        [Required]
        public int Stock { get; set; }

    }
}
