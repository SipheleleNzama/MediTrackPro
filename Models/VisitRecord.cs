namespace MediTrackPro.Models
{
    public class VisitRecord
    {
        public int Id { get; set; }
        public string? Diagnosis { get; set; }
        public string? Prescriptions { get; set; }
        public string? Notes { get; set; }
        // Foreign key
        public int AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
    }
}
