using AutoMapper;
using ClassificationAppBackend.Data.Repos.UserRepo;
using ClassificationAppBackend.DTO;
using ClassificationAppBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

namespace ClassificationAppBackend.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IRepoUser _userRepo;
        private readonly IMapper _mapper;

        public UserController(IMapper mapper,IRepoUser userRepo)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }


        /// <summary>
        /// Gets a User by ID
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        [Route("{id}")]
        public ActionResult<UserModel> GetUserById(int id)
        {
            var user = _userRepo.GetUser(id);
            
            if(user == null)
            {
                return NotFound();
            }
            return user;

        }

        [SwaggerRequestExample(typeof(UserDTO), typeof(UserDTO))]
        [HttpPost]
        public ActionResult PostUser(UserDTO userDTO)
        {
            var user = _mapper.Map<UserModel>(userDTO);
            
            _userRepo.AddUser(user);

            return CreatedAtRoute(nameof(GetUserById),new {Id = user.Id},user);
        }
    }
}