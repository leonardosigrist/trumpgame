using System.ComponentModel.DataAnnotations;

namespace TrumpGame.Model
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public int Points { get; set; }
    }
}
