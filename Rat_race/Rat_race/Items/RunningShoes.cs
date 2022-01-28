using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Rat_race
{
    internal class RunningShoes : Equipment
    {
        public RunningShoes()
        {
            Name = "RunningShoes";
            BonusSpeed = 1;
            Price = 100;
        }
        public RunningShoes(Animal animal)
        {
            Name = "RunningShoes";
            BonusSpeed = 1;
            Price = 100;
            IsInUse = true;
            Animal = animal;
        }
        public RunningShoes(string name)
        {
            Name = name;
            BonusSpeed = 1;
            Price = 100;
        }
        public RunningShoes(string name, Animal animal)
        {
            Name = name;
            BonusSpeed = 1;
            Price = 100;
            IsInUse = true;
            Animal = animal;
        }
    }
}
