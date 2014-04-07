using System.Data.Entity;
using TrumpGame.Model;

namespace TrumpGame.Data
{
    public class TrumpGameContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeCategory> AttributeCategories { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GamePlayer> GamePlayers { get; set; }
    }
}
