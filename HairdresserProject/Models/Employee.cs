namespace HairdresserProject.Models{
public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Expertise { get; set; }
    public string Availability { get; set; } // Could be a list or specific time range

    // Foreign key for Salon
    public int SalonId { get; set; }
    // Navigation property for Salon
    public Salon Salon { get; set; }

    // Navigation property for appointments
    public ICollection<Appointment> Appointments { get; set; }

    public ICollection<EmployeeService> EmployeeServices { get; set; }
}
}

