using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Racer_type
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
            ResetAnimal();
            _size = 6;
            _isFlying = false;
            _isClimbing = false;
            _isGliding = false;
            _speed = 8;
            Items = new List<Equipment>() { };
        }
    }
}
