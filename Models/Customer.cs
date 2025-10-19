using System.ComponentModel.DataAnnotations;

namespace PieceOfArtSystem.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required, EmailAddress] // validation at the request's level
        // since there is no '?', then it's not nullable, so in the DB the column is set NOT NULL
        public string Email { get; set; } = null!; //validation on the DB level (server error if not provided in a create request)

        public string Phone { get; set; } = null!;
    }
}
