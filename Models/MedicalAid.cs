namespace MediTrackPro.Models
{
    public class MedicalAid
    {
        public int Id { get; set; }
        public string? ProviderName { get; set; }
        public string? PlanType { get; set; }
        public string? MemberNumber { get; set; }
        public bool IsActive { get; set; }
        // Foreign key
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
