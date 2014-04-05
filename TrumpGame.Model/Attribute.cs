using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame.Model
{
    public class Attribute
    {
        public int Id { get; set; }
        public AttributeCategory AttributeCategory { get; set; }
        public Card Card { get; set; }
        public int Value { get; set; }
    }
}
