using System.Numerics;

namespace MediTrackPro.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string? Status { get; set; } // Booked, Cancelled, Attended
        public string? Notes { get; set; }
        // Foreign keys
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
