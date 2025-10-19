using System.ComponentModel.DataAnnotations;

namespace PieceOfArtSystem.Models
{
    public class ArtPiece
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; } = null!;
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required, Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
