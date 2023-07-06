using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperDuckLibrary.Models
{
    public class BorrowList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowId { get; set; } = 0;

        [ForeignKey("Books")]
        public int Fk_BookId { get; set; } = 0;
        public virtual Book? Books { get; set; }

        [ForeignKey("Customers")]
        public int Fk_CustomerId { get; set; } = 0;
        public virtual Customer? Customers { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BorrowedDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DueDate { get; set; } = DateTime.Now.AddDays(28);

        public bool? IsReturned { get; set; } = false;
    }
}
