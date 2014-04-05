using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame.Model
{
    public class GamePlayer
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public Game Game { get; set; }
    }
}
