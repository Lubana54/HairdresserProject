using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HairdresserProject.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //gfhfjkj
        // Burada tablolarınızı tanımlayabilirsiniz
        // public DbSet<ModelAdi> Tablolar { get; set; }
    }
}
