using PatrolPal.Enum;

namespace PatrolPal.Model
{
    public class FirDetails : Audit
    {
        public int FirNumber { get; set; }
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }
        public CaseStatus Status { get; set; }
        public required string Address { get; set; }
        public string? Description { get; set; }
        public required string ReporterName { get; set; }
        public required string ReporterPhone { get; set; }
        public required string ReporterAddress { get; set; }
        public string? Reason { get; set; }

    }
}
