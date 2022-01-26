using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rat_race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RaceManager RaceManager = new RaceManager();
            File.Delete("Race Logs.txt");

            while (true)
            {
                Console.WriteLine("[0] Quit");
                Console.WriteLine("[1] Start a race");
                Console.WriteLine("[2] View the last race report");
                Console.WriteLine("[3] Create a new race");
                Console.WriteLine("[4] Create a new track");
                Console.WriteLine("[5] Add a new rat to the race");
                Console.WriteLine("[6] Signup a new player for betting");
                Console.WriteLine("[7] Place a new bet");
                string awn = Console.ReadLine();

                switch (awn)
                {
                    case "1":
                        Console.WriteLine("Select race");
                        if (RaceManager.Races.Count > 0)
                        {
                            for (int i = 0; i < RaceManager.Races.Count(); i++)
                            {
                                Console.WriteLine("[{0}] {1}", i, RaceManager.Races[i].RaceID);
                            }
                            int race = Convert.ToInt32(Console.ReadLine());
                            RaceManager.CunductRace(RaceManager.Races[race]);
                        }
                        else
                        {
                            Console.WriteLine("There are no races at the moment");
                        }
                        break;
                    case "2":
                        if (RaceManager.Races.Count() > 0)
                        {
                            Console.WriteLine("Select Race");
                            for (int i = 0; i < RaceManager.Races.Count(); i++)
                            {
                                Console.WriteLine("[{0}] {1}", i, RaceManager.Races[i]);
                            }
                            int race = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(RaceManager.ViewRaceReport(RaceManager.Races[race]));
                        }
                        else
                        {
                            Console.WriteLine("There are no races at the moment");
                        }
                        break;
                    case "3":
                        if (RaceManager.Tracks.Count() > 0)
                        {
                            Console.WriteLine ("Select track");
                            for (int i = 0; i < RaceManager.Tracks.Count(); i++)
                            {
                                Console.WriteLine("[{0}] {1}", i, RaceManager.Tracks[i].Name);
                            }
                            int track = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter race ID: ");
                            int raceID = Convert.ToInt32(Console.ReadLine());
                            RaceManager.CreateRace(raceID, RaceManager.Rats, RaceManager.Tracks[track]);
                        }
                        else
                        {
                        Console.WriteLine("There are no tracks at the moment");
                        }
                        break;
                    case "4":
                        Console.Write("Enter the name of the track: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the length of the track: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        RaceManager.CreateTrack(name, length);
                        break;
                    case "5":
                        Console.Write("Enter the name of the rat: ");
                        name = Console.ReadLine();
                        RaceManager.CreateRat(name);
                        break;
                    case "6":
                        Console.Write("Enter the new players name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter the new players Balance: ");
                        int balance = Convert.ToInt32(Console.ReadLine());
                        RaceManager.CreatePlayer(name, balance);
                        break;
                    case "7":
                        if (RaceManager.Players.Count > 0 && RaceManager.Races.Count > 0 && RaceManager.Rats.Count > 0)
                        {
                            Console.WriteLine("Who is making the bet?");
                            for (int i = 0; i < RaceManager.Players.Count; i++)
                            {
                                Console.WriteLine("[{0}] {1}", i, RaceManager.Players[i].Name);
                            }
                            Player player = RaceManager.Players[Convert.ToInt32(Console.ReadLine())];
                            Console.WriteLine("What race would they like to bet on?");
                            for (int i = 0; i < RaceManager.Races.Count; i++)
                            {
                                Console.WriteLine("[{0}] {1}", i, RaceManager.Races[i].RaceID);
                            }
                            Race race = RaceManager.Races[Convert.ToInt32(Console.ReadLine())];
                            Console.WriteLine("what rat would you like to bet on?");
                            for (int i = 0; i < race.Rats.Count; i++)
                            {
                                Console.WriteLine("[{0}] {1}", i, race.Rats[i].Name);
                            }
                            Rat rat = race.Rats[Convert.ToInt32(Console.ReadLine())];
                            Console.Write("Enter the size if the bet: ");
                            int wager = Convert.ToInt32(Console.ReadLine());
                            RaceManager.Bookmaker.PlaceBet(race, rat, player, wager);
                        }
                        break;
                }
                if (awn == "0")
                {
                    break;
                }
            }
        }
    }
}
