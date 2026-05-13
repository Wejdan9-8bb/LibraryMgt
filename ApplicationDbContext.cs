using LibraryMgt.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryMgt
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<UserInfo> UserInfoes {  get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authores { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        
    }
}
