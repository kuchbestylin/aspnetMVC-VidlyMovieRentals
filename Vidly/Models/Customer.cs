using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        [Required]
        public MembershipType? MembershipType { get; set; }
    }
}
