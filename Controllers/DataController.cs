using AutoMapper;
using ClassificationAppBackend.Data.Repos.HeartFailureDataRepo;
using ClassificationAppBackend.Data.Repos.StrokeDataRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using ClassificationAppBackend.Models.Diseases.Stroke;
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
        private readonly IRepoStrokeData _repoStrokeData;
        private readonly IMapper _mapper;

        public DataController(IRepoHeartFailureData repoHeartFailureData, IRepoStrokeData repoStrokeData, IMapper mapper )
        {
            _repoHeartFailureData = repoHeartFailureData;
            _repoStrokeData = repoStrokeData;
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

                [HttpGet]
        [Route("stroke/{bmi}")]
        public ActionResult<StrokeReturnModel> GetStatsForStroke(int bmi) {
            IEnumerable<StrokeDataModel> strokeData = (IEnumerable<StrokeDataModel>)_repoStrokeData.GetAll();
            int len = strokeData.Count();
            int hypertension = strokeData.Where(o => o.HasHypertension == 1).Count();
            int heartDisease = strokeData.Where(o => o.HasHeartDisease == 1).Count();
            int highBMI = strokeData.Where(o => o.BMI >= bmi).Count();
            int smokes = strokeData.Where(o => o.SmokingStatus == "1").Count();
            int stroke = strokeData.Where(o => o.Target == 1).Count();
            StrokeReturnModel res = new StrokeReturnModel(len, hypertension, heartDisease, highBMI, smokes, stroke);
            return Ok(res);
        }
    }
}