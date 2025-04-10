namespace MediTrackPro.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IDNumber { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Allergies { get; set; }
        public string? EmergencyContact { get; set; }
        // Navigation properties
        public ICollection<Appointment>? Appointments { get; set; }
        public MedicalAid MedicalAid { get; set; }
    }
}
