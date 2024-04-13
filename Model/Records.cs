namespace PatrolPal.Model
{
    public class Records : Audit
    {
        public required string DocName { get; set; }
        public required string Type { get; set; }
        public string? DocLocation { get; set; }
        public string? UploadBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? Content { get; set; }
    }
}
