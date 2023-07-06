using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HyperDuckLibrary.Models
{
    public class Customer
    {
            [Key]
            public int CustomerId { get; set; }

            [Required]
            [MaxLength(20)]
            public string FirstMidName { get; set; }


            [Required]
            [MaxLength(25)]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            [MaxLength(50)]
            public string Email { get; set; }

            [Required]
            [MaxLength(15)]
            public string PhoneNumber { get; set; }

            [Required]
            public string UserName { get; set; }

           public virtual ICollection<BorrowList>? BorrowList { get; set; }
    }

}
