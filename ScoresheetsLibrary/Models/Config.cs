namespace ScoresheetsLibrary.Models
{
    public class Config
    {
        public enum ScoringSystems
        {
            Metric,
            Imperial
        }

        public enum FaceSizes
        {
            ExtraSmall = 40,
            Small = 60,
            Medium = 80,
            Standard = 122
        }

        public enum Places
        {
            Indoors,
            Outdoors
        }

        public int Distance { get; internal set; }
        public int ArrowsPerEnd { get; internal set; }
        public int NumberOfEnds { get; internal set; }
        public ScoringSystems ScoringSystem { get; internal set; }
        public FaceSizes FaceSize { get; internal set; }
        public Places Place { get; internal set; }

        public Config(int distance = 30, int arrowsPerEnd = 6, int numberOfEnds = 6,
                      ScoringSystems scoringSystem = ScoringSystems.Imperial, 
                      FaceSizes faceSize = FaceSizes.Standard, Places place = Places.Outdoors)
        {
            Distance = distance;
            ArrowsPerEnd = arrowsPerEnd;
            NumberOfEnds = numberOfEnds;
            ScoringSystem = scoringSystem;
            FaceSize = faceSize;
            Place = place;
        }

    }
}
