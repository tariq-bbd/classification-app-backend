using AutoMapper;
using ClassificationAppBackend.Data.Repos.HeartFailureDataRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [Route("api/data/heart_failure")]
    public class DataController : ControllerBase
    {
        private readonly IRepoHeartFailureData _repoHeartFailureData;
        private readonly IMapper _mapper;

        public HeartFailureController(IRepoHeartFailureData repoHeartFailureData, IMapper mapper )
        {
            _repoHeartFailureData = repoHeartFailureData;
            _mapper = mapper;
            
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<HeartFailureData> GetAllHeartFailureData()
        {
            return Ok(_repoHeartFailureData.GetAll());
        }

        [HttpPost]
        [Route("add")]
        public ActionResult AddHeartFailureData(HeartFailurePredictionDTO heartFailurePredictionDTO)
        {
            return Ok();
        }
    }
}