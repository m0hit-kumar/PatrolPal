namespace PatrolPal.Model
{
    public class Users : Audit
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public string? Email { get; set; }
        public string? Station { get; set; }
        public required string PoliceId { get; set; }
        public DateTime? JoiningDate { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
