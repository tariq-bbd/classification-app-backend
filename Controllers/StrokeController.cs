using AutoMapper;
using ClassificationAppBackend.Data.Repos.StrokeRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.Models.Diseases.Stroke;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        [Route("predict")]
        public ActionResult<PredictionModel> GetPredictionResult(StrokePredictionDTO strokePredictionDTO)
        {
          //  var strokePredictionModel = _mapper.Map<StrokePredictionModel>(strokePredictionDTO);
            var predictionResult = _repoStroke.Predict(new StrokePredictionModel());
            return Ok(predictionResult);
        }
    }
}