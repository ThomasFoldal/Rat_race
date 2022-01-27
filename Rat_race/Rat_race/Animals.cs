using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Rat:Animal
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
        }
    }
    public class SpiderMonkey:Animal
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
        }
    }
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
        }
    }
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
        }
    }

}
