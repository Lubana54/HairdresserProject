namespace HairdresserProject.Models{
public class Appointment
{
    public int AppointmentId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public decimal Price { get; set; }

    // Foreign key for Employee
    public int EmployeeId { get; set; }
    // Navigation property for Employee
    public Employee Employee { get; set; }

    // Foreign key for Service
    public int ServiceId { get; set; }
    // Navigation property for Service
    public Service Service { get; set; }

    // Navigation property for User (customer)
    public int UserId { get; set; }
    public User User { get; set; }
}

}
