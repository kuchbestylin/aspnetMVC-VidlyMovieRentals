using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {


        public int Id { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string? Name { get; set; }


        public bool IsSubscribedToNewsLetter { get; set; }



        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }



        [Required]
        [Display(Name = "Membership Type")]
        public MembershipType? MembershipType { get; set; }


    }
}

