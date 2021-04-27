using AutoMapper;
using ClassificationAppBackend.Data.Repos.StrokeRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
using Microsoft.AspNetCore.Mvc; 
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;
using System.Linq;


namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [Route("api/diseases/stroke")]
    public class StrokeController : ControllerBase
    {
        private readonly IRepoStroke _repoStroke;
        private readonly IMapper _mapper;

        public StrokeController(IRepoStroke repoStroke, IMapper mapper )
        {
            _repoStroke = repoStroke;
            _mapper = mapper;
            
        }


        /// <summary>
        /// Predict if a person is likely to have a stroke
        /// </summary>
        [HttpPost]
        [Route("predict")]
        [SwaggerRequestExample(typeof(StrokePredictionDTO), typeof(StrokePredictionDTO))]
        public ActionResult<PredictionModel> GetPredictionResult(StrokePredictionDTO strokePredictionDTO)
        {
            var strokePredictionModel = _mapper.Map<StrokePredictionModel>(strokePredictionDTO);
            var predictionResult = _repoStroke.Predict(strokePredictionModel);
            return Ok(predictionResult);
        }

                /// <summary>
        /// Gets n records for heart Failure
        /// </summary>
        /// <param name="numOfRecords"></param>
        [HttpGet]
        [Route("records/heartFailure/{numOfRecords}")]
        public ActionResult<List<StrokePredictionModel>> GetRecordsForHeartFailure(int numOfRecords) {
            IEnumerable<StrokePredictionModel> heartFailurePredictData = _repoStroke.GetXRecords(numOfRecords);
            return Ok(heartFailurePredictData.ToList());
        }
    }
}