using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Track
    {
        public string Name;
        public int TrackLength;
        private Dictionary<int, Shortcut> _shortcuts = new Dictionary<int, Shortcut>();
        public Track(string name, int trackLength)
        {
            Name = name;
            TrackLength = trackLength;
        }
        public void AddShortcut(int entrance, int exit, int size, bool needsFlying, bool needsClimbing, bool needsGliding)
        {
            _shortcuts.Add(entrance, new Shortcut(exit, size, needsFlying, needsClimbing, needsGliding));
        }
        public bool TjekForShortcut(int position)
        {
            return _shortcuts.ContainsKey(position);
        }
        public void TakeSchortcut(Animal animal)
        {
            if (TjekForShortcut(animal.Position))
            {
                if (_shortcuts[animal.Position].CanTake(animal))
                {
                    animal.Position = _shortcuts[animal.Position].GetExit();
                }
            }
        }
    }
}
