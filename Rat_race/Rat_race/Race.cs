using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rat_race
{
    public class Race
    {
        public int RaceID;
        public List<Rat> Rats = new List<Rat>();
        public Track RaceTrack;
        private Rat _winner;
        private List<Rat> _tiePodium = new List<Rat>();
        private bool _isTie;
        private string _log;

        public Race(int raceID, List<Rat> rats, Track raceTrack)
        {
            RaceID = raceID;
            Rats = rats;
            RaceTrack = raceTrack;
        }

        public void ConductRace()
        {
            foreach (Rat steve in Rats)
            {
                steve.ResetRat();
            }
            while (_winner == null)
            {
                foreach(Rat steve in Rats)
                {
                    steve.MoveRat();
                    if (_winner == null && steve.Position >= RaceTrack.TrackLength)
                    {
                        _winner = steve;
                    }
                    else if (_winner != null && steve.Position >= RaceTrack.TrackLength)
                    {
                        if (!_isTie)
                        {
                            _tiePodium.Add(_winner);
                            _tiePodium.Add(steve);
                        }
                        else
                        {
                            _tiePodium.Add(steve);
                        }
                        _isTie = true;
                    }
                }
                _log = "";
                foreach(Rat steve in Rats)
                {
                    _log += steve.Name + steve.Position + "|";
                }
                LogRace(_log);
            }
            Console.WriteLine(_winner.Name + " Won the race");
        }
        public Rat GetWinner()
        {
            if (_winner != null)
            { 
                return _winner;
            }
            Console.WriteLine("No winner has been found");
            return null;
        }
        public string GetReport()
        {
            string report = "The race " + RaceID +" is a race between ";
            foreach (Rat steve in Rats)
            {
                report += steve.Name + ", ";
            }
            report += "on the " + RaceTrack + "track";
            return report;
        }
        private void LogRace(string log)
        {
            using (StreamWriter file = new StreamWriter("Race Logs.txt", append: true))
            {
                file.WriteLine(log);
            }
        }
    }
}
