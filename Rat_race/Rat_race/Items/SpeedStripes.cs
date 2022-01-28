using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Rat_race
{ 
    internal class SpeedStripes : Equipment
    {
        public SpeedStripes()
        {
            Name = "Speed Stripes";
            BonusSpeed = 2;
            Price = 1000;
        }
        public SpeedStripes(string name)
        {
            Name = name;
            BonusSpeed = 2;
            Price = 1000;
        }
        public SpeedStripes(string name, Animal animal)
        {
            Name = name;
            BonusSpeed = 2;
            Price = 1000;
            IsInUse = true;
            Animal = animal;
        }
        public SpeedStripes(Animal animal)
        {
            Name = "Speed Stripes";
            BonusSpeed = 2;
            Price = 1000;
            IsInUse = true;
            Animal = animal;
        }
    }
}
