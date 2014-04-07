using System.ComponentModel.DataAnnotations;

namespace TrumpGame.Model
{
    public class AttributeCategory
    {
        [Key]
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
    }
}
