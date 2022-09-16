using Microsoft.EntityFrameworkCore;

namespace ListBook.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
