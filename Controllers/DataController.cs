using AutoMapper;
using ClassificationAppBackend.Data.Repos.HeartFailureDataRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


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
        public ActionResult<HeartFailureDataModel> AddHeartFailureData(HeartFailureDataModel heartFailureData)
        {
            _repoHeartFailureData.AddHeartFailureData(heartFailureData);
            return Ok(heartFailureData);
        }

        [HttpGet]
        [Route("heart_failure/{chest_pain_l}/{cholestrol_l}")]
        public ActionResult<HeartFailureReturnModel> GetStatsForHeartFailure(int chest_pain_l, int cholestrol_l) {
            IEnumerable<HeartFailureDataModel> hearFailureData = (IEnumerable<HeartFailureDataModel>)_repoHeartFailureData.GetAll();
            int len = hearFailureData.Count();
            int chest_pain = hearFailureData.Where(o => o.Chest_pain_type > chest_pain_l).Count();
            int cholestrol = hearFailureData.Where(o => o.Cholesterol > cholestrol_l).Count();
            int exercise_engina = hearFailureData.Where(o => o.Exercise_angina == "").Count();
            int heart_failure = hearFailureData.Where(o => o.Target == 1).Count();
            HeartFailureReturnModel res = new HeartFailureReturnModel(len, chest_pain, cholestrol, exercise_engina, heart_failure);
            return Ok(res);
        }
    }
}