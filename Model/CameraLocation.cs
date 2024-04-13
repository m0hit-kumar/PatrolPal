using PatrolPal.Enum;

namespace PatrolPal.Model
{
    public class CameraLocation : Audit
    {
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }
        public required string Address { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? LastWorkingDate { get; set; }
        public bool IsGov { get; set; } = false;
        public string? OwnerDetails { get; set; }
        public DistrictEnum District { get; set; }
    }
}
