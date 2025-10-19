using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PieceOfArtSystem.Models
{
    [Index(nameof(CardNumber), IsUnique = true)]
    public class LoyaltyCard
    {
        public int Id { get; set; }
        [Required]
        public string CardNumber { get; set; } = null!;
        public decimal Balance { get; set; }
    }

}
