using PatrolPal.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatrolPal.Model
{
    public class PoliceStations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }
        public required string Address { get; set; }
        public string? PendingCases { get; }
        public string? ActiveCases { get; set; }
        public string? OnDutyOfficials { get; set; }
        public string? OffDutyOfficials { get; set; }
        public DistrictEnum District { get; set; }
    }
}
