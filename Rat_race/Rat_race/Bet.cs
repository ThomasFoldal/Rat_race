using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Bet
    {
        private int _money;
        private Player _player;
        private Race _race;
        private Rat _rat;

        public Bet(int money, Player player, Race race, Rat rat)
        {
            _money = money;
            _player = player;
            _race = race;
            _rat = rat;
        }

        //TK
        public void PayWinner()
        {
            _player.Money += _money;
        }
    }
}
