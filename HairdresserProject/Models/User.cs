namespace HairdresserProject.Models{
public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Navigation property for appointments
    public ICollection<Appointment> Appointments { get; set; }
}

}
