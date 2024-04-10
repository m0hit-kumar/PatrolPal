using System.Reflection.Metadata.Ecma335;

namespace PatrolPal.Model
{
    public class Raw : Audit
    {
        public required string DocName { get; set; }
        public required string Type { get; set; }
        public string? DocLocation { get; set; }
        public string? UploadBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Content { get; set; }
    }
}
