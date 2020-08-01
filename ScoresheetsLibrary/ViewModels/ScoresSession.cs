using System;
using ScoresheetsLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace ScoresheetsLibrary.ViewModels
{
    public class ScoresSession
    {
        public List<Entry> CurrentEntries { get; private set; }
        public Config CurrentConfig { get; private set; }

        public ScoresSession()
        {
            CurrentEntries = new List<Entry>();
            CurrentConfig = new Config();
            NewEntry("testOne");
        }

        public void ChangeDistance(int distance)
        {
            CurrentConfig.Distance = distance;
        }

        public void ChangeArrowsPerEnd(int arrowsPerEnd)
        {
            CurrentConfig.ArrowsPerEnd = arrowsPerEnd;
        }

        public void ChangeNumberOfEnds(int numberOfEnds)
        {
            CurrentConfig.NumberOfEnds = numberOfEnds;
        }

        public void ChangeScoringSystem(string scoringSystem)
        {
            switch(scoringSystem)
            {
                case "Metric":
                    CurrentConfig.ScoringSystem = Config.ScoringSystems.Metric;
                    break;
                case "Imperial":
                    CurrentConfig.ScoringSystem = Config.ScoringSystems.Imperial;
                    break;
                default:
                    throw new ArgumentException("Invalid scoring system");
            }
        }

        public void ChangeFaceSize(string faceSize)
        {
            switch(faceSize)
            {
                case "40cm":
                    CurrentConfig.FaceSize = Config.FaceSizes.ExtraSmall;
                    break;
                case "60cm":
                    CurrentConfig.FaceSize = Config.FaceSizes.Small;
                    break;
                case "80cm":
                    CurrentConfig.FaceSize = Config.FaceSizes.Medium;
                    break;
                case "122cm":
                    CurrentConfig.FaceSize = Config.FaceSizes.Standard;
                    break;
                default:
                    throw new ArgumentException("Invalid face size");
            }
        }

        public void ChangePlace(string place)
        {
            switch(place)
            {
                case "Indoors":
                    CurrentConfig.Place = Config.Places.Indoors;
                    break;
                case "Outdoors":
                    CurrentConfig.Place = Config.Places.Outdoors;
                    break;
                default:
                    throw new ArgumentException("Invalid location");
            }
        }

        public void NewEntry(string entryName)
        {
            CurrentEntries.Add(new Entry(entryName,
                                         CurrentConfig));
        }
    }
}
