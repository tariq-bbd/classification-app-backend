using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models.Diseases.HeartFailure
{
    public class HeartFailurePredictionModel
    {
        [Required]
        public float Age { get; set; }
        [Required]
        [MaxLength(250)]
        public string Sex { get; set; }
        [Required]
        public float Chest_pain_type { get; set; }
        [Required]
        public float Resting_bp_s { get; set; }
        [Required]
        public float Cholesterol { get; set; }
        [Required]
        [MaxLength(250)]
        public string Fasting_blood_sugar { get; set; }
        [Required]
        [MaxLength(250)]
        public string Resting_ecg { get; set; }
        [Required]
        public float Max_heart_rate { get; set; }
        [Required]
        [MaxLength(250)]
        public string Exercise_angina { get; set; }
        [Required]
        public float Oldpeak { get; set; }
        [Required]
        public float ST_slope { get; set; }
        [Required]
        [MaxLength(250)]
        public string Target { get; set; }
    }
}