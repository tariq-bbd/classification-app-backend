using AutoMapper;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models.Diseases.Stroke;

namespace ClassificationAppBackend.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PatientDTO,PatientModel>();
            CreateMap<StrokePredictionDTO,StrokePredictionModel>();
        }
    }
}