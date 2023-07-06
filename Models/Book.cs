using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperDuckLibrary.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; } = 0;

        [Required]
        public string BookName { get; set; }
        [Required]
        public string BookDescription { get; set; }
        [Required]
        public string Author { get; set; }


        public virtual ICollection<BorrowList>? BorrowList { get; set; }



    }
}
