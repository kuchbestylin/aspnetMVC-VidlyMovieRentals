using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Customer
    {


        public int Id { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string Name { get; set; }


        public bool IsSubscribedToNewsLetter { get; set; }



        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }


        [Display(Name = "Membership Type")]
        [ForeignKey("MembershipType")]
        [Required]
        public int MembershipTypeId { get; set; }
        public MembershipType? MembershipType { get; set; }


    }
}

