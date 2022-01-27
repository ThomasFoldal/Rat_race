using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Animal
    {
        protected int _position;
        public string Name;
        public int _size;
        public bool _isFlying;
        public bool _isClimbing;
        public bool _isGliding;
        protected int _speed;

        public int Position
        {
            get { return _position; }
            set { if (_position != value) { _position = value; Console.WriteLine("position has changed"); } }
        }
        public void ResetAnimal()
        {
            _position = 0;
        }
        public int MoveAnimal()
        {
            _position += RNG.Range(1, _speed);
            return _position;
        }
    }
}
