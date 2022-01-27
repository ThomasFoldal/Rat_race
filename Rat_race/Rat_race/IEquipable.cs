using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public interface IEquipable
    {
        bool IsInUse { get; set; }
        Animal Animal { get; set; }
        void Don();
        void Doff();
        void Effect();
    }
}
