namespace PatrolPal.Model
{
    public class PoliceLocation : Audit
    {
        public required string PoliceId { get; set; }
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }
        public required string CurAddress { get; set; }
        public string? Phone { get; set; }
    }
}
