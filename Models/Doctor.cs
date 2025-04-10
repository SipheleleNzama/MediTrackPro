namespace MediTrackPro.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Specialty { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }

        // Navigation property
        public ICollection<Appointment>? Appointments { get; set; }
    }
}