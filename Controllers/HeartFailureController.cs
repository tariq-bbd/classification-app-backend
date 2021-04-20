using AutoMapper;
using ClassificationAppBackend.Data.Repos.HeartFailureRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using Microsoft.AspNetCore.Mvc;

namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [Route("api/diseases/heart_failure")]
    public class HeartFailureController : ControllerBase
    {
        private readonly IHeartFailure _repoHeartFailure;
        private readonly IMapper _mapper;

        public HeartFailureController(IRepoHeartFailure repoHeartFailure, IMapper mapper )
        {
            _repoHeartFailure = repoHeartFailure;
            _mapper = mapper;
            
        }

        [HttpGet]
        [Route("predict")]
        public ActionResult<PredictionModel> GetPredictionResult(HeartFailurePredictionDTO heartFailurePredictionDTO)
        {
            var heartFailurePredictionModel = _mapper.Map<HeartFailurePredictionModel>(heartFailurePredictionDTO);
            var predictionResult = _repoHeartFailure.Predict(heartFailurePredictionModel);
            return Ok(predictionResult);
        }
    }
}