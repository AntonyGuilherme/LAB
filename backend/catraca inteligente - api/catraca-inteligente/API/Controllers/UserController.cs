using Applicaition.Dto;
using Applicaition.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_userService.GetAll());

        [HttpGet]
        public IActionResult GetById([FromRoute] int id) => Ok(_userService.GetUser(id));


        [HttpPost]
        public IActionResult SingUp([FromBody] UserSingUpRequest userRequest) => Ok(_userService.SingUp(userRequest));

        [HttpPut]
        public IActionResult Update([FromRoute] int id, [FromBody] UserUpdateRequest userRequest) => Ok(_userService.UpdateUser(id, userRequest));

        [HttpDelete]
        public IActionResult Delete([FromRoute] int id) => Ok(_userService.DeleteUser(id));


    }
}
