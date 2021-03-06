using AutoMapper;
using ClassificationAppBackend.Models;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models.Diseases.Stroke;
using ClassificationAppBackend.Models.Diseases.HeartFailure;
using ClassificationModel;

namespace ClassificationAppBackend.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDTO,UserModel>();
            CreateMap<StrokePredictionDTO,StrokePredictionModel>();
            CreateMap<HeartFailurePredictionDTO,HeartFailurePredictionModel>();    
        }
    }
}