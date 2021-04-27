using AutoMapper;
using ClassificationAppBackend.Data.Repos.HeartFailureRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;
using System.Linq;


namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [Route("api/diseases/heart_failure")]
    public class HeartFailureController : ControllerBase
    {
        private readonly IRepoHeartFailure _repoHeartFailure;
        private readonly IMapper _mapper;

        public HeartFailureController(IRepoHeartFailure repoHeartFailure, IMapper mapper )
        {
            _repoHeartFailure = repoHeartFailure;
            _mapper = mapper;
            
        }

        
        /// <summary>
        /// Predict if a person is likely to have heart failure
        /// </summary>
        [HttpGet]
        [Route("predict")]
        [SwaggerRequestExample(typeof(HeartFailurePredictionDTO), typeof(HeartFailurePredictionDTO))]
        public ActionResult<PredictionModel> GetPredictionResult(HeartFailurePredictionDTO heartFailurePredictionDTO)
        {
            var heartFailurePredictionModel = _mapper.Map<HeartFailurePredictionModel>(heartFailurePredictionDTO);
            var predictionResult = _repoHeartFailure.Predict(heartFailurePredictionModel);
            return Ok(predictionResult);
        }

        /// <summary>
        /// Gets n records for heart Failure
        /// </summary>
        /// <param name="numOfRecords"></param>
        [HttpGet]
        [Route("records/heartFailure/{numOfRecords}")]
        public ActionResult<List<HeartFailurePredictionModel>> GetRecordsForHeartFailure(int numOfRecords) {
            IEnumerable<HeartFailurePredictionModel> heartFailurePredictData = _repoHeartFailure.GetXRecords(numOfRecords);
            return Ok(heartFailurePredictData.ToList());
        }
    }
}