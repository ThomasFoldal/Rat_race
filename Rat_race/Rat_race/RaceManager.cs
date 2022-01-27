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
        public List<Animal> Animals = new List<Animal>();
        public Bookmaker Bookmaker = new Bookmaker();
        public RaceManager()
        {
            CreateRat("Ben D. Dover");
            CreateRat("ice Wallow Come");
            CreatePlayer("Jhon Jones Jr.", 9000000);
            CreateTrack("Cafateria", 100, 15, 25, 3, false, false, false, 50, 57, 5, false, false, false);
        }
        public Race CreateRace(int raceID, List<Animal> rats, Track track)
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
        public Track CreateTrack(string name, int trackLength, int entrance, int exit, int size, bool flying, bool climbing, bool gliding)
        {
            Track newTrack = new Track(name, trackLength);
            AddShortcutToTrack(newTrack, entrance, exit, size, flying, climbing, gliding);
            Tracks.Add(newTrack);
            return newTrack;
        }
        public Track CreateTrack(string name, int trackLength, 
            int entrance1, int exit1, int size1, bool flying1, bool climbing1, bool gliding1, 
            int entrance2, int exit2, int size2, bool flying2, bool climbing2, bool gliding2)
        {
            Track newTrack = new Track(name, trackLength);
            AddShortcutToTrack(newTrack, entrance1, exit1, size1, flying1, climbing1, gliding1);
            AddShortcutToTrack(newTrack, entrance2, exit2, size2, flying2, climbing2, gliding2);
            Tracks.Add(newTrack);
            return newTrack;
        }
        public Track CreateTrack(string name, int trackLength,
            int entrance1, int exit1, int size1, bool flying1, bool climbing1, bool gliding1,
            int entrance2, int exit2, int size2, bool flying2, bool climbing2, bool gliding2,
            int entrance3, int exit3, int size3, bool flying3, bool climbing3, bool gliding3)
        {
            Track newTrack = new Track(name, trackLength);
            AddShortcutToTrack(newTrack, entrance1, exit1, size1, flying1, climbing1, gliding1);
            AddShortcutToTrack(newTrack, entrance2, exit2, size2, flying2, climbing2, gliding2);
            AddShortcutToTrack(newTrack, entrance3, exit3, size3, flying3, climbing3, gliding3);
            Tracks.Add(newTrack);
            return newTrack;
        }
        public void AddShortcutToTrack(Track track, int entrance, int exit, int size, bool flying, bool climbing, bool gliding)
        {
            track.AddShortcut(entrance, exit, size, flying, climbing, gliding);
        }
        public void CunductRace(Race race)
        {
            race.ConductRace();
            foreach (Bet bet in Bookmaker.Bets)
            {
                Bookmaker.PayOutWinnings(race);
            }
            Races.Remove(race);
        }
        public string ViewRaceReport(Race race)
        {
            return race.GetReport();
        }
        public Rat CreateRat(string name)
        {
            Rat newRat = new Rat(name);
            Animals.Add(newRat);
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
