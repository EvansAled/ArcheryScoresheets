using System;
using ScoresheetsLibrary.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace ScoresheetsLibrary.ViewModels
{
    public class ScoresSession : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Entry> CurrentEntries { get; private set; }
        private Entry _currentEntry;
        public Config CurrentConfig { get; private set; }

        public Entry CurrentEntry
        {
            get => _currentEntry;
            set
            {
                _currentEntry = value;
                OnPropertyChanged();
            }
        }

        public ScoresSession()
        {
            CurrentEntries = new ObservableCollection<Entry>();
            CurrentEntry = null;
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

        public void ChangeCurrentEntry(object entry)
        {
            CurrentEntry = (Entry)entry;
        }

        public void NewEntry(string entryName)
        {
            CurrentEntries.Add(new Entry(entryName,
                                         CurrentConfig));
        }

        public void RemoveEntry(Entry entryToRemove)
        {
            CurrentEntries.Remove(entryToRemove);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
