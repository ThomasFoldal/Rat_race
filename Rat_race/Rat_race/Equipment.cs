using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public abstract class Equipment : IEquipable
    {
        public string Name;
        public int BonusSpeed;
        public int Price;
        public bool IsInUse { get; set; }
        public Animal Animal { get; set; }

        public Equipment()
        {
            Name = "";
            BonusSpeed = 0;
            Price = 0;
            IsInUse = false;
            Animal = null;
        }
        // gives equipment to an animal
        public virtual void GiveTo(Animal animal)
        {
            Animal = animal;
        }
        // tells animal not to use Equipment
        public virtual void Doff()
        {
            if (IsInUse)
            {
                IsInUse = false;
            }
        }
        public virtual void Don()
        {
            if (!IsInUse)
            {
                IsInUse = true;
            }
        }
        // Adds the bonus speed to the animals position
        public void Effect()
        {
            if (IsInUse)
            {
                Animal.Position += BonusSpeed;
            }
        }
    }
}
