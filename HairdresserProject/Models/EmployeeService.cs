namespace HairdresserProject.Models
{
    public class EmployeeService
    {
        public int EmployeeId { get; set; }
        public Employee ?Employee { get; set; }

        public int ServiceId { get; set; }
        public Service ?Service { get; set; }
    }
}
