using PatrolPal.Enum;

namespace PatrolPal.Model
{
    public class MapStats : Audit
    {
        public DistrictEnum District { get; set; }
        public string? CrimeRate { get; set; }
        public string? PendingCases { get; set; }
        public string? ActiveCases { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
    }
}
