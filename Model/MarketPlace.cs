using PatrolPal.Enum;
using System.ComponentModel.DataAnnotations;

namespace PatrolPal.Model
{
    public class MarketPlace : Audit
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageLink { get; set; }
        public AppType? Type { get; set; }
        public bool IsGov { get; set; } = false;
        public bool IsPaid { get; set; } = false;
        public double? Rating { get; set; }
    }
}
