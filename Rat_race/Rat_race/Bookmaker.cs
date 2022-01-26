using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Bookmaker
    {
        public List<Bet> Bets = new List<Bet>();

        // TK
        public Bet PlaceBet(Race race, Rat rat, Player player, int money)
        {
            player.PlaceBet(money);

            Bet newBet = new Bet(money,player,race,rat);
            Bets.Add(newBet);
            return newBet;
        }
        public void PayOutWinnings(Race race)
        {
            foreach (Bet b in Bets)
            {
                if (b.Race == race)
                {
                    b.PayWinner();
                }
            }
        }
    }
}
