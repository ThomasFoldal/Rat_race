using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Rat_race
{
    internal class RocketEngine : Equipment
    {
        public RocketEngine()
        {
            Name = "Rocket Engine";
            BonusSpeed = 10;
            Price = 100000000;
        }
        public RocketEngine(Animal animal)
        {
            Name = "Rocket Engine";
            BonusSpeed = 10;
            Price = 100000000;
            IsInUse = true;
            Animal = animal;
        }
        public RocketEngine(string name)
        {
            Name = name;
            BonusSpeed = 10;
            Price = 100000000;
        }
        public RocketEngine(string name, Animal animal)
        {
            Name = name;
            BonusSpeed = 10;
            Price = 100000000;
            IsInUse = true;
            Animal = animal;
        }
        //TK
        public override void Don()
        {
            //Warning about killing the animal here!
        }
    }
}
