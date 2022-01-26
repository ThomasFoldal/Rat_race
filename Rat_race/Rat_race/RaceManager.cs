using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rat_race
{
    public class RaceManager
    {
        public List<Track> Tracks = new List<Track>();
        public List<Player> Players = new List<Player>();
        public List<Race> Races = new List<Race>();
        public List<Rat> Rats = new List<Rat>();
        public Bookmaker Bookmaker = new Bookmaker();
        public RaceManager()
        {
            CreateRat("Ben D. Dover");
            CreateRat("ice Wallow Come");
            CreatePlayer("Jhon Jones Jr.", 9000000);
            CreateTrack("Cafateria", 100);
        }
        public Race CreateRace(int raceID, List<Rat> rats, Track track)
        {
            Race newRace = new Race(raceID, rats, track);
            Races.Add(newRace);
            return newRace;
        }
        public Track CreateTrack(string name, int trackLength)
        {
            Track newTrack = new Track(name, trackLength);
            Tracks.Add(newTrack);
            return newTrack;
        }
        public void CunductRace(Race race)
        {
            race.ConductRace();
        }
        public string ViewRaceReport(Race race)
        {
            return race.GetReport();
        }
        public Rat CreateRat(string name)
        {
            Rat newRat = new Rat(name);
            Rats.Add(newRat);
            return newRat;
        }
        public Player CreatePlayer(string name, int money)
        {
            Player newPlayer = new Player(name, money);
            Players.Add(newPlayer);
            return newPlayer;
        }
    }
}
