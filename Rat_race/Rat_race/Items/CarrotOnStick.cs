using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Rat_race
{
    internal class CarrotOnStick : Equipment
    {
        public CarrotOnStick()
        {
            Name = "Carrot On Stick";
            BonusSpeed = 2;
            Price = 100;
            IsInUse = true;
        }
        public CarrotOnStick(Animal animal)
        {
            Name = "Carrot On Stick";
            BonusSpeed = 2;
            Price = 100;
            IsInUse = true;
            Animal = animal;
        }
    }
}
