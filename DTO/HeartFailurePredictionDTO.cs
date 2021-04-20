using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.DTO
{
    public class HeartFailurePredictionDTO
    {
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