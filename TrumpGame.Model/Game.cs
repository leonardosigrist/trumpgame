using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TrumpGame.Model
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public Category Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public DbSet<GamePlayer> GamePlayers { get; set; }  
    }
}
