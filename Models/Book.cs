using System.ComponentModel.DataAnnotations;

namespace HyperDuckLibrary.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string BookName { get; set; }
        [Required]
        public string BookDescription { get; set; }
        [Required]
        public string Author { get; set; }



        public DateTime? BorrowedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }

        public bool? IsReturned { get; set; }

        public virtual ICollection<BorrowList>? BorrowList { get; set; }



    }
}
