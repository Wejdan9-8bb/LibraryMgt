
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryMgt.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int YearPublished { get; set; }
        public string? Genre { get; set; }


        public int AuthorId { get; set; }
        public Author? Author { get; set; }


        public string? CoverImage { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public int BorrowCount { get; set; }
        public ICollection<Borrow>? Borrows { get; set; }
    }
}
