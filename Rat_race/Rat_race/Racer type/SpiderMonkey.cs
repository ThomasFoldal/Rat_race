using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rat_race;

namespace Racer_type
{
    public class SpiderMonkey : Animal
    {
        public SpiderMonkey(string name)
        {
            Name = name;
            ResetAnimal();
            _size = 4;
            _isFlying = false;
            _isClimbing = true;
            _isGliding = false;
            _speed = 7;
            Items = new List<Equipment>() { };
        }
    }
}
