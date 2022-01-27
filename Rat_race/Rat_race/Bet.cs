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
        public Race Race;
        private Animal _dyr;

        public Bet(int money, Player player, Race race, Animal dyr)
        {
            _money = money;
            _player = player;
            Race = race;
            _dyr = dyr;
        }
        //TK
        public void PayWinner()
        {
            Animal winner = Race.GetWinner();
            if(_dyr == winner)
            {
            _player.Money += _money;
                Console.WriteLine("{0} won {1}", _player, _money);
            }
            else
            {
                Console.WriteLine(_player + " lost");
            }
        }
    }
}
