using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models.Diseases.Stroke
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
        public int HasHypertension { get; set; } // all with 1
        [Required]
        public int HasHeartDisease  { get; set; } // all with 1
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
        public double BMI { get; set; } // all with bmi above x
        [Required]
        [MaxLength(250)]
        public string SmokingStatus { get; set; } // all true
        [Required]
        public int Target { get; set; } // all with 1
    }
}