using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public DateTime? Release { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Added { get; set; }

        [Required]
        [Range(1, 20)]
        public int Stock { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}
