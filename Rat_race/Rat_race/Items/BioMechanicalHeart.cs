using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Rat_race
{
    internal class BioMechanicalHeart : Equipment
    {
        public BioMechanicalHeart()
        {
            Name = "BioMechanicalHeart";
            BonusSpeed = 4;
            Price = 1000000;
            IsInUse = true;
        }
        public BioMechanicalHeart(Animal animal)
        {
            Name = "BioMechanicalHeart In " + animal.Name;
            BonusSpeed = 4;
            Price = 1000000;
            IsInUse = true;
            Animal = animal;
        }
        //TK
        public override void GiveTo(Animal animal)
        {
            //kills Animal
        }
        public override void Doff()
        {
            //kills Animal
        }
        // does nothing because animal should be dead
        public override void Don()
        {

        }
    }
}
