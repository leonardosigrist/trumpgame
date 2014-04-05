using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame.Model
{
    public class AttributeCategory
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
    }
}
