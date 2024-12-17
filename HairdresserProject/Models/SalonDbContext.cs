using Microsoft.EntityFrameworkCore;

namespace HairdresserProject.Models
{
public class SalonDbContext : DbContext
{
    public SalonDbContext(DbContextOptions<SalonDbContext> options) : base(options) { }

    public DbSet<Salon> Salons { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<EmployeeService> EmployeeServices { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Define many-to-many relationship between Employee and Service
        modelBuilder.Entity<EmployeeService>()
            .HasKey(es => new { es.EmployeeId, es.ServiceId });

        modelBuilder.Entity<EmployeeService>()
            .HasOne(es => es.Employee)
            .WithMany(e => e.EmployeeServices)
            .HasForeignKey(es => es.EmployeeId);

        modelBuilder.Entity<EmployeeService>()
            .HasOne(es => es.Service)
            .WithMany(s => s.EmployeeServices)
            .HasForeignKey(es => es.ServiceId);
    }
}

}
