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

        [HttpPost("singin")]
        public IActionResult SignIn(UserSingInRequest singInRequest)
        {
            var result = _userService.SingIn(singInRequest);
            if (result == null) return NoContent();
            else return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result == null) return NoContent();
            else return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var result = _userService.GetUser(id);
            if (result == null) return NoContent();
            else return Ok(result);
        }


        [HttpPost]
        public IActionResult SingUp([FromBody] UserSingUpRequest userRequest) => Ok(_userService.SingUp(userRequest));

        [HttpPut]
        public IActionResult Update([FromRoute] int id, [FromBody] UserUpdateRequest userRequest) => Ok(_userService.UpdateUser(id, userRequest));

        [HttpDelete]
        public IActionResult Delete([FromRoute] int id) => Ok(_userService.DeleteUser(id));


    }
}
