using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models.Diseases.Stroke
{
    public class StrokeReturnModel
    {
        [Required]
        public int TotalCases { get; set; }
        [Required]
        public int Hypertension { get; set; }
        [Required]
        public int HeartDisease { get; set; }
        [Required]
        public int HighBMI { get; set; }
        [Required]
        public int Smokes { get; set; }
        [Required]
        public int Stroke { get; set; }

        public StrokeReturnModel(int totalCases, int hypertension, int heartDisease, int highBMI, int smokes, int stroke)
        {
            this.TotalCases = totalCases;
            this.Hypertension = hypertension;
            this.HeartDisease = heartDisease;
            this.HighBMI = highBMI;
            this.Smokes = smokes;
            this.Stroke = stroke;
        }
    }
}