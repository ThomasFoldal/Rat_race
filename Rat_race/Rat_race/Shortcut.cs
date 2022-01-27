using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Shortcut
    {
        private int exit;
        private bool _needsFlying;
        private bool _needsClimbing;
        private bool _needsGliding;
        private int _size;
        public Shortcut(int Exit, int size ,bool needsFlying, bool needsClimbing, bool needsGliding)
        {
            exit = Exit;
            _size = size;
            _needsFlying = needsFlying;
            _needsClimbing = needsClimbing;
            _needsGliding = needsGliding;
        }
        public bool CanTake(Animal animal)
        {
            bool flyingreq = false;
            bool climbingreq = false;
            bool glidingreq = false;
            if (_needsFlying)
            {
                if (animal._isFlying)
                {
                    flyingreq = true;
                }
            }
            else
            {
                flyingreq = true;
            }
            if (_needsClimbing)
            {
                if (animal._isClimbing)
                {
                    climbingreq = true;
                }
            }
            else
            {
                climbingreq = true;
            }
            if (_needsGliding)
            {
                if (animal._isGliding || animal._isFlying)
                {
                    glidingreq = true;
                }
            }
            else
            {
                glidingreq = true;
            }

            if (animal._size <= _size && flyingreq && climbingreq && glidingreq)
            {
                return true;
            }
            return false;
        }
        public int GetExit()
        {
            return exit;
        }
    }
}
