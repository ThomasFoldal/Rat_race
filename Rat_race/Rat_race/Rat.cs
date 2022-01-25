using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Rat
    {
        public string Name;
        private int _position;
        public int Position { get; set; }

        public void ResetRat()
        {
            Position = 0;
        }
        public int MoveRat()
        {
            _position = RNG.Range(0, 5);
            Position += _position;
        }
    }
}
