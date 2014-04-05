using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame.Model
{
    public class Card
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public bool Trump { get; set; }
        public string Summary { get; set; }
    }
}
