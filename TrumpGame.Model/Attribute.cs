using System.ComponentModel.DataAnnotations;

namespace TrumpGame.Model
{
    public class Attribute
    {
        [Key]
        public int Id { get; set; }
        public AttributeCategory AttributeCategory { get; set; }
        public Card Card { get; set; }
        public int Value { get; set; }
    }
}
