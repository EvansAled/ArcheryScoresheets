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

        public void NewEntry(string entryName)
        {
            CurrentEntries.Add(new Entry(entryName,
                                         CurrentConfig));
        }
    }
}
