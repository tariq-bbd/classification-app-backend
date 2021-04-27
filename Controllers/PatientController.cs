using AutoMapper;
using ClassificationAppBackend.Data.Repos.PatientRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Examples;

namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientController : ControllerBase
    {
        private readonly IRepoPatient _patientRepo;
        private readonly IMapper _mapper;

        public PatientController(IMapper mapper,IRepoPatient patientRepo)
        {
            _patientRepo = patientRepo;
            _mapper = mapper;
        }


        /// <summary>
        /// Gets a patient by ID
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        [Route("{id}")]
        public ActionResult<PatientModel> GetPatientById(int id)
        {
            var patient = _patientRepo.GetPatient(id);
            
            if(patient == null)
            {
                return NotFound();
            }
            return patient;

        }

        [SwaggerRequestExample(typeof(PatientDTO), typeof(PatientDTO))]
        [HttpPost]
        public ActionResult PostPatient(PatientDTO patientDTO)
        {
            var patient = _mapper.Map<PatientModel>(patientDTO);
            
            _patientRepo.AddPatient(patient);

            return CreatedAtRoute(nameof(GetPatientById),new {Id = patient.Id},patient);
        }
    }
}