using AutoMapper;
using ClassificationAppBackend.Data.Repos.HeartFailureDataRepo;
using ClassificationAppBackend.Data.Repos.StrokeDataRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using ClassificationAppBackend.Models.Diseases.Stroke;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.AspNetCore.Cors;

namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [EnableCors("MyPolicy")]
    [Route("api/data")]
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

        /// <summary>
        /// Gets Stats for heart failure
        /// </summary>
        [HttpGet]
        [Route("all")]
        public ActionResult<HeartFailureDataModel> GetAllHeartFailureData()
        {
            return Ok(_repoHeartFailureData.GetAll());
        }

        /// <summary>
        /// Adds Stats for heart failure
        /// </summary>
        [HttpPost]
        [Route("add")]
        public ActionResult<HeartFailureDataModel> AddHeartFailureData(HeartFailureDataModel heartFailureData)
        {
            _repoHeartFailureData.AddHeartFailureData(heartFailureData);
            return Ok(heartFailureData);
        }


        /// <summary>
        /// Gets Stats for heart failure
        /// </summary>
        /// <param name="chest_pain_l"></param>
        /// <param name="cholestrol_l"></param>
        [HttpGet]
        [Route("heart_failure/{chest_pain_l}/{cholestrol_l}")]
        public ActionResult<HeartFailureReturnModel> GetStatsForHeartFailure(int chest_pain_l, int cholestrol_l) {
            IEnumerable<HeartFailureDataModel> hearFailureData = (IEnumerable<HeartFailureDataModel>)_repoHeartFailureData.GetAll();
            int len = hearFailureData.Count();
            int chest_pain = hearFailureData.Where(o => o.ChestPainType > chest_pain_l).Count();
            int cholestrol = hearFailureData.Where(o => o.Cholesterol > cholestrol_l).Count();
            int exercise_engina = hearFailureData.Where(o => o.ExerciseAngina == true).Count();
            int heart_failure = hearFailureData.Where(o => o.Target == true).Count();
            HeartFailureReturnModel res = new HeartFailureReturnModel(len, chest_pain, cholestrol, exercise_engina, heart_failure);
            return Ok(res);
        }


        /// <summary>
        /// Gets Stats for stroke
        /// </summary>
        /// <param name="bmi"></param>
        [HttpGet]
        [Route("stroke/{bmi}")]
        public ActionResult<StrokeReturnModel> GetStatsForStroke(double bmi) {
            IEnumerable<StrokeDataModel> strokeData = (IEnumerable<StrokeDataModel>)_repoStrokeData.GetAll();
            int len = strokeData.Count();
            int hypertension = strokeData.Where(o => o.HasHypertension == true).Count();
            int heartDisease = strokeData.Where(o => o.HasHeartDisease == true).Count();
            int highBMI = strokeData.Where(o => o.BMI >= bmi).Count();
            int smokes = strokeData.Where(o => o.SmokingStatus != "never smoked" && o.SmokingStatus != "Unknown" ).Count();
            int stroke = strokeData.Where(o => o.Target == true).Count();
            StrokeReturnModel res = new StrokeReturnModel(len, hypertension, heartDisease, highBMI, smokes, stroke);
            return Ok(res);
        }


        /// <summary>
        /// Gets n records for stroke
        /// </summary>
        /// <param name="numOfRecords"></param>
        [HttpGet]
        [Route("records/stroke/{numOfRecords}")]
        public ActionResult<List<StrokeDataModel>> GetRecordsForStroke(int numOfRecords) {
            IEnumerable<StrokeDataModel> strokeData = (IEnumerable<StrokeDataModel>)_repoStrokeData.GetAll();
            return Ok(strokeData.OrderByDescending(o => o.Id).Take(numOfRecords).ToList());
        }

        /// <summary>
        /// Gets n records for heart disease
        /// </summary>
        /// <param name="numOfRecords"></param>
        [HttpGet]
        [Route("records/heartFailure/{numOfRecords}")]
        public ActionResult<List<HeartFailureDataModel>> GetRecordsForHeartFailure(int numOfRecords) {
            IEnumerable<HeartFailureDataModel> heartFailureData = (IEnumerable<HeartFailureDataModel>)_repoHeartFailureData.GetAll();
            return Ok(heartFailureData.OrderByDescending(o => o.Id).Take(numOfRecords).ToList());
        }

    }
}