using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Player
    {
        public Player(string name, int money)
        {
            Name = name;
            Money = money;
            Bets = new List<Bet>();
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public List<Bet> Bets { get; set; }

        // TK
        public void PlaceBet(int bet)
        {
            Money -= bet;
        }

    }
}
