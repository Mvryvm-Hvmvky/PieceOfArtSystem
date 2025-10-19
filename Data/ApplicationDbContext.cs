using Microsoft.EntityFrameworkCore;

namespace PieceOfArtSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
