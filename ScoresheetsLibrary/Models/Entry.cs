using System;
using System.Collections.Generic;
using System.Linq;

namespace ScoresheetsLibrary.Models
{
    public class Entry
    {
        public string EntryName { get; private set; }
        public List<Score> Scores { get; private set; }
        public Config Configuration { get; private set; }

        public int Total
        {
            get => (int)Scores.Sum(s => s.score);
        }

        public int TotalGolds
        {
            get => Scores.Count(s => s.isGold == true);
        }

        public Entry(string entryName, Config configuration)
        {
            EntryName = entryName;
            Scores = new List<Score>();
            Configuration = configuration;
        }

        public void AddScore(Score score)
        {
            if(Scores.Count != Configuration.ArrowsPerEnd)
            {
                Scores.Add(score);
            }
            else
            {
                throw new InvalidOperationException("Number of arrows per end already reached.");
            }
        }
    }
}
