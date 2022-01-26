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
        private Rat _rat;

        public Bet(int money, Player player, Race race, Rat rat)
        {
            _money = money;
            _player = player;
            Race = race;
            _rat = rat;
        }
        //TK
        public void PayWinner()
        {
            Rat winner = Race.GetWinner();
            if(_rat == winner)
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
