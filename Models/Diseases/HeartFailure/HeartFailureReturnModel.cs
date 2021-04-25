using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models.Diseases.HeartFailure
{
    public class HeartFailureReturnModel
    {
        [Required]
        public int TotalCases { get; set; }
        [Required]
        public int ChestPain { get; set; }
        [Required]
        public int Cholestrol { get; set; }
        [Required]
        public int ExcerciseEngina { get; set; }
        [Required]
        public int HeartFailure { get; set; }

        public HeartFailureReturnModel(int totalCases, int chestPain, int cholestrol, int excercise, int heart)
        {
            this.TotalCases = totalCases;
            this.ChestPain = chestPain;
            this.Cholestrol = cholestrol;
            this.ExcerciseEngina = excercise;
            this.HeartFailure = heart;
        }
    }
}