using ClassificationAppBackend.Data;
using ClassificationAppBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepo _patientRepo;

        public PatientController(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
        }


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
    }
}