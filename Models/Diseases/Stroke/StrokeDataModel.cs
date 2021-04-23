using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models.Diseases.HeartFailure
{
    public class StrokeDataModel
    {
        [Required]
        public int Id { get; set; } //Patient ID
        [Required]
        [MaxLength(250)]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int HasHypertension { get; set; }
        [Required]
        public int HasHeartDisease  { get; set; }
        [Required]
        [MaxLength(250)]
        public string EverMarried { get; set; }
        [Required]
        [MaxLength(250)]
        public string WorkType { get; set; }
        [Required]
        [MaxLength(250)]
        public string ResidenceType { get; set; }
        [Required]
        [MaxLength(250)]
        public double AverageGlucoseLevel { get; set; }
        [Required]
        public double BMI { get; set; }
        [Required]
        [MaxLength(250)]
        public string SmokingStatus { get; set; }
        [Required]
        public int Target { get; set; }
    }
}