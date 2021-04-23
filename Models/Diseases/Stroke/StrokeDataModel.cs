using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SuggestMe.Models
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