using AutoMapper;
using ClassificationAppBackend.Data.Repos.StrokeRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
using Microsoft.AspNetCore.Mvc; 
using Swashbuckle.Examples;

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
    }
}