using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models.Diseases.HeartFailure
{
    public class HeartFailurePredictionModel
    {
        [Required]
        public int Id { get; set; } //Patient ID
        [Required]
        public int Age { get; set; }
        [Required]
        public bool Anaemia { get; set; }
        [Required]
        public int CreatininePhosphokinase { get; set; }
        [Required]
        public bool Diabetes { get; set; }
        [Required]
        public int EjectionFraction { get; set; }
        [Required]
        public bool HighBloodPressure { get; set; }
        [Required]
        public int Platelets { get; set; }
        [Required]
        public float SerumCreatinine { get; set; }
        [Required]
        public int SerumSodium { get; set; }
        [Required]
        public int Sex { get; set; }
        [Required]
        public bool Smoking { get; set; }
        [Required]
        public int Time { get; set; }
    }
}