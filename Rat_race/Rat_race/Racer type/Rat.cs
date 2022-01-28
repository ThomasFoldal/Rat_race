using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Racer_type
{
    public class Rat : Animal
    {
        public Rat(string name)
        {
            Name = name;
            ResetAnimal();
            _size = 3;
            _isFlying = false;
            _isClimbing = false;
            _isGliding = false;
            _speed = 6;
            Items = new List<Equipment>() { };
        }
    }
}
