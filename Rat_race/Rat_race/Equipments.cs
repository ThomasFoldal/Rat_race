using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class RunningShoes : Equipment
    {
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
    public class SpeedStripes : Equipment
    {
        public SpeedStripes(string name)
        {
            Name=name;
            BonusSpeed=2;
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
    }
    public class BioMechanicalHeart : Equipment
    {
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
    public class RocketEngine : Equipment
    {
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
    }
}
