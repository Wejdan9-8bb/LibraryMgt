using System.ComponentModel.DataAnnotations;

namespace LibraryMgt.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? UserType { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? FullName { get; set; }
    }
}
