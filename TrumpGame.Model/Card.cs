using System.ComponentModel.DataAnnotations;

namespace TrumpGame.Model
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public bool Trump { get; set; }
        public string Summary { get; set; }
    }
}
