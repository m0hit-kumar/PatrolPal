using System.ComponentModel.DataAnnotations.Schema;

namespace PatrolPal.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public required string Name { get; set; }

        public required string Password { get; set; }

        public required string Email { get; set; }
    }
}
