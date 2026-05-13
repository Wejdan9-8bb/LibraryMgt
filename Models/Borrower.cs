
using System.ComponentModel.DataAnnotations;

namespace LibraryMgt.Models
{
    public class Borrower
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "FullName")]
        public string? FullName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? Phone { get; set; }
        public ICollection<Borrower> Borrowers { get; set; } = new List<Borrower>();
    }
}
