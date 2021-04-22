//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace ClassificationModel.Stroke
{
    public class ClassificationModelInput
    {
        [ColumnName("Gender"), LoadColumn(0)]
        public string Gender { get; set; }


        [ColumnName("Age"), LoadColumn(1)]
        public float Age { get; set; }


        [ColumnName("HasHypertension"), LoadColumn(2)]
        public float HasHypertension { get; set; }


        [ColumnName("HasHeartDisease"), LoadColumn(3)]
        public float HasHeartDisease { get; set; }


        [ColumnName("EverMarried"), LoadColumn(4)]
        public bool EverMarried { get; set; }


        [ColumnName("WorkType"), LoadColumn(5)]
        public string WorkType { get; set; }


        [ColumnName("ResidenceType"), LoadColumn(6)]
        public string ResidenceType { get; set; }


        [ColumnName("AverageGlucoseLevel"), LoadColumn(7)]
        public float AverageGlucoseLevel { get; set; }


        [ColumnName("BMI"), LoadColumn(8)]
        public float BMI { get; set; }


        [ColumnName("SmokingStatus"), LoadColumn(9)]
        public string SmokingStatus { get; set; }


        [ColumnName("HadStroke"), LoadColumn(10)]
        public string HadStroke { get; set; }


    }
}
