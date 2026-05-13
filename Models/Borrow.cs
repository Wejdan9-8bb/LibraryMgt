using System.ComponentModel.DataAnnotations;

namespace LibraryMgt.Models
{
    public class Borrow
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int BorrowerId { get; set; }
        public Borrower? Borrower { get; set; }
        [Display(Name = "Borrow Date")]
        public DateTime BorrowDate { get; set; }
        [Display(Name = "Return Date")]
        public DateTime? ReturnDate { get; set; }
        public string? DeliveredBy { get; set; }
        public int? Rating { get; set; }
    }
}
