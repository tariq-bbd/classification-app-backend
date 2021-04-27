//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.ML;

namespace ClassificationModel.HeartFailure
{
    public class ConsumeModel
    {
        private static Lazy<PredictionEngine<ClassificationModelInput, ClassificationModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ClassificationModelInput, ClassificationModelOutput>>(CreatePredictionEngine);

        public static string MLNetModelPath = Path.GetFullPath("ClassificationModel\\HeartFailure\\MLModel.zip");

        // For more info on consuming ML.NET models, visit https://aka.ms/mlnet-consume
        // Method for consuming model in your app
        public static ClassificationModelOutput Predict(ClassificationModelInput input)
        {
            ClassificationModelOutput result = PredictionEngine.Value.Predict(input);
            return result;
        }

        public static PredictionEngine<ClassificationModelInput, ClassificationModelOutput> CreatePredictionEngine()
        {
            // Create new MLContext
            MLContext mlContext = new MLContext();

            // Load model & create prediction engine
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var ClassificationModelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ClassificationModelInput, ClassificationModelOutput>(mlModel);

            return predEngine;
        }
    }
}
