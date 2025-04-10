namespace MediTrackPro.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string? UserId { get; set; } // From Identity
        public string? Action { get; set; } // "Created Patient", "Updated Appointment"
        public DateTime Timestamp { get; set; }
    }
}
