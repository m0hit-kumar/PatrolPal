namespace PatrolPal.Model
{
    public class PoliceStations
    {
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }
        public required string Address { get; set; }
        public string? PendingCases { get; }
        public string? ActiveCases { get; set; }
        public string? OnDutyOfficials { get; set; }
        public string? OffDutyOfficials { get; set; }

    }
}
