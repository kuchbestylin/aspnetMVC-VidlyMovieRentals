using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? Birthdate { get; set; }

        [Required]
        public int MembershipTypeId { get; set; }
    }
}
