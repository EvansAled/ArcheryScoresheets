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

        public int Distance { get; private set; }
        public int ArrowsPerEnd { get; private set; }
        public ScoringSystems ScoringSystem { get; private set; }
        public FaceSizes FaceSize { get; private set; }
        public Places Place { get; private set; }

        public Config(int distance = 30, int arrowsPerEnd = 6, ScoringSystems scoringSystem = ScoringSystems.Imperial, 
                      FaceSizes faceSize = FaceSizes.Standard, Places place = Places.Outdoors)
        {
            Distance = distance;
            ArrowsPerEnd = arrowsPerEnd;
            ScoringSystem = scoringSystem;
            FaceSize = faceSize;
            Place = place;
        }

    }
}
