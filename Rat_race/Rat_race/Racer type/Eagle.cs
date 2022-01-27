using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race.Racer_type
{
    public class Eagle : Animal
    {
        public Eagle(string name)
        {
            Name = name;
            ResetAnimal();
            _size = 8;
            _isFlying = true;
            _isClimbing = false;
            _isGliding = false;
            _speed = 7;
        }
    }
}
