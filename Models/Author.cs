using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryMgt.Models
{
    public class Author
    {

        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Nationality { get; set; }
        public string? photo { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
