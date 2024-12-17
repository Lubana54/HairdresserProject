using System.ComponentModel.DataAnnotations;
namespace HairdresserProject.Models{
 public class Service
    {
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Duration { get; set; } // e.g., "30 minutes", "1 hour"

        // Foreign key for Salon
        public int SalonId { get; set; }
        // Navigation property for Salon
        public Salon Salon { get; set; }

        // Many-to-many relationship with Employee
        public ICollection<EmployeeService> EmployeeServices { get; set; }
    }

}

   
