using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public static class RNG
    {
        private static Random rng = new Random();

        public static int Range(int upper, int lower)
        {
            return rng.Next(upper, lower);
        }
    }
}
