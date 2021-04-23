using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models.Diseases.HeartFailure
{
    public class HeartFailureDataModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public float Age { get; set; }
        [Required]
        [MaxLength(250)]
        public string Sex { get; set; }
        [Required]
        public float Chest_pain_type { get; set; } // above
        [Required]
        public float Resting_bp_s { get; set; }
        [Required]
        public float Cholesterol { get; set; } // Above x
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
        public string Exercise_angina { get; set; } // all with it
        [Required]
        public float Oldpeak { get; set; }
        [Required]
        public float ST_slope { get; set; }
        [Required]
        public int Target { get; set; } // Select all with 1
    }
}