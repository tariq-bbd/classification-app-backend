using AutoMapper;
using ClassificationAppBackend.Data.Repos.HeartFailureDataRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using Microsoft.AspNetCore.Mvc;

namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [Route("api/data/heart_failure")]
    public class DataController : ControllerBase
    {
        private readonly IRepoHeartFailureData _repoHeartFailureData;
        private readonly IMapper _mapper;

        public DataController(IRepoHeartFailureData repoHeartFailureData, IMapper mapper )
        {
            _repoHeartFailureData = repoHeartFailureData;
            _mapper = mapper;
            
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<HeartFailureDataModel> GetAllHeartFailureData()
        {
            return Ok(_repoHeartFailureData.GetAll());
        }

        [HttpPost]
        [Route("add")]
        public ActionResult<HeartFailureDataModel> AddHeartFailureData(HeartFailureData heartFailureData)
        {
            _repoHeartFailureData.Add(heartFailureData);
            return Ok(heartFailureData);
        }
    }
}