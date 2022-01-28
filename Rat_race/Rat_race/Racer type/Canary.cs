using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Racer_type
{
    public class Canary : Animal
    {
        public Canary(string name)
        {
            Name = name;
            ResetAnimal();
            _size = 2;
            _isFlying = true;
            _isClimbing = false;
            _isGliding = false;
            _speed = 9;
            Items = new List<Equipment>() { };
        }
    }
}
