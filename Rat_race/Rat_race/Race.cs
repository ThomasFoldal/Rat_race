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
        public List<Animal> Animals = new List<Animal>();
        public Track RaceTrack;
        private Animal _winner;
        private List<Animal> _tiePodium = new List<Animal>();
        private bool _isTie;
        private string _log;

        public Race(int raceID, List<Animal> rats, Track raceTrack)
        {
            RaceID = raceID;
            Animals = rats;
            RaceTrack = raceTrack;
        }

        public void ConductRace()
        {
            foreach (Animal steve in Animals)
            {
                steve.ResetAnimal();
            }
            while (_winner == null)
            {
                _log = "";
                foreach (Animal steve in Animals)
                {
                    if (RaceTrack.TjekForShortcut(steve.Position))
                    {
                        RaceTrack.TakeSchortcut(steve);
                        _log += steve.Name + " took a shortcut|";
                    }
                    steve.MoveAnimal();

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
                foreach (Animal steve in Animals)
                {
                    _log += steve.Name + steve.Position + "|";
                }
                LogRace(_log);
            }
            Console.WriteLine(_winner.Name + " Won the race");
        }
        public Animal GetWinner()
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
            string report = "The race " + RaceID + " is a race between ";
            foreach (Animal steve in Animals)
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
