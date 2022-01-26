﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class Bookmaker
    {
        public List<Bet> Bets { get; set; }

        // TK
        public Bet PlaceBet(Race race, Rat rat, Player player, int money)
        {
            player.PlaceBet(money);
            return new Bet(money,player,race,rat);
        }
        public void PayOutWinnings(Bet bet)
        {
            bet.PayWinner();
        }
    }
}
