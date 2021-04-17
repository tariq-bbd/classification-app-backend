namespace ClassificationAppBackend.Models.Diseases
{
    public class StrokeModel
    {
        public int Id { get; set; } //Patient ID
        public string Gender { get; set; }
        public int Age { get; set; }
        public int HasHypertension { get; set; }

        public int HasHeartDisease  { get; set; }
        public string EverMarried { get; set; }
        public string WorkType { get; set; }
        public string ResidenceType { get; set; }
        public double AverageGlucoseLevel { get; set; }
        public double BMI { get; set; }
        public string SmokingStatus { get; set; }
        public int HadStroke { get; set; }
    }
}