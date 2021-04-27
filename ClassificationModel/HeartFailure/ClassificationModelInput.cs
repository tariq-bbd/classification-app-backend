//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace ClassificationModel.HeartFailure
{
    public class ClassificationModelInput
    {
        [ColumnName("Age"), LoadColumn(0)]
        public float Age { get; set; }


        [ColumnName("Sex"), LoadColumn(1)]
        public float Sex { get; set; }


        [ColumnName("Chest_pain_type"), LoadColumn(2)]
        public float Chest_pain_type { get; set; }


        [ColumnName("Resting_bp_s"), LoadColumn(3)]
        public float Resting_bp_s { get; set; }


        [ColumnName("Cholesterol"), LoadColumn(4)]
        public float Cholesterol { get; set; }


        [ColumnName("Fasting_blood_sugar"), LoadColumn(5)]
        public float Fasting_blood_sugar { get; set; }


        [ColumnName("Resting_ecg"), LoadColumn(6)]
        public float Resting_ecg { get; set; }


        [ColumnName("Max_heart_rate"), LoadColumn(7)]
        public float Max_heart_rate { get; set; }


        [ColumnName("Exercise_angina"), LoadColumn(8)]
        public float Exercise_angina { get; set; }


        [ColumnName("Oldpeak"), LoadColumn(9)]
        public float Oldpeak { get; set; }


        [ColumnName("ST_slope"), LoadColumn(10)]
        public float ST_slope { get; set; }


        [ColumnName("Target"), LoadColumn(11)]
        public string Target { get; set; }


    }
}
