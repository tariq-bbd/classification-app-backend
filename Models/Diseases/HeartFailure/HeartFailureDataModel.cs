using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models.Diseases.HeartFailure
{
    public class HeartFailureDataModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [MaxLength(250)]
        public string Sex { get; set; }
        [Required]
        public int ChestPainType { get; set; } // above
        [Required]
        public int RestingBpS { get; set; }
        [Required]
        public int Cholesterol { get; set; } // Above x
        [Required]
        public bool FastingBloodSugar { get; set; }
        [Required]
        public bool RestingEcg { get; set; }
        [Required]
        public int MaxHeartRate { get; set; }
        [Required]
        public bool ExerciseAngina { get; set; } // all with it
        [Required]
        public float Oldpeak { get; set; }
        [Required]
        public int StSlope { get; set; }
        [Required]
        public bool Target { get; set; } // Select all with 1
    }
}