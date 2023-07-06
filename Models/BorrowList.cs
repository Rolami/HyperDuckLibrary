using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperDuckLibrary.Models
{
    public class BorrowList
    {
        [Key]
        public int BorrowId { get; set; }

        [ForeignKey("Books")]
        public int Fk_BookId { get; set; }
        public virtual Book Books { get; set; }

        [ForeignKey("Customers")]
        public int Fk_CustomerId { get; set; }
        public virtual Customer Customers { get; set; }

    }
}
