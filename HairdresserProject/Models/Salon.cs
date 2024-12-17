namespace HairdresserProject.Models{
public class Salon
{
    public int SalonId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string WorkingHours { get; set; }

    // Navigation property for services
    public ICollection<Service> Services { get; set; }
    // Navigation property for employees
    public ICollection<Employee> Employees { get; set; }
}
}


