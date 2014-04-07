using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TrumpGame.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DbSet<AttributeCategory> AttributeCategories { get; set; }
    }
}
