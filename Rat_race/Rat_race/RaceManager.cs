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
            Rats.Add(CreateRat("Ben D. Dover"));
            Rats.Add(CreateRat("ice Wallow Come"));
            Players.Add(CreatePlayer("Jhon Jones Jr.", 9000000));
            Tracks.Add(CreateTrack("Horserace Stadium", 5000));
        }
        public Race CreateRace(int raceID, List<Rat> rats, Track track)
        {
            return new Race(raceID, rats, track);
        }
        public Track CreateTrack(string name, int trackLength)
        {
            return new Track(name, trackLength);
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
            return new Rat(name);
        }
        public Player CreatePlayer(string name, int money)
        {
            return new Player(name, money);
        }
    }
}
