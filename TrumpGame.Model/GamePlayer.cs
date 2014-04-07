using System.ComponentModel.DataAnnotations;

namespace TrumpGame.Model
{
    public class GamePlayer
    {
        [Key]
        public int Id { get; set; }
        public Player Player { get; set; }
        public Game Game { get; set; }
    }
}
