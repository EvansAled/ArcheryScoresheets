using System;
using System.Collections.Generic;
using System.Text;

namespace ScoresheetsLibrary.Models
{
    public class Score
    {
        public int score { get; private set; }
        public bool isGold => score >= 9;

        public Score(int value)
        {
            score = value;
        }
    }
}
