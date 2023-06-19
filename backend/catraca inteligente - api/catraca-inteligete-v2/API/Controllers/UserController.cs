using Applicaition.Dto;
using Applicaition.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("user/singin")]
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

        [HttpGet("user/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var result = _userService.GetUser(id);
            if (result == null) return NoContent();
            else return Ok(result);
        }

        [HttpGet("access")]
        public IActionResult CanUserAccess([FromQuery] string cardId)
        {
            return Ok(_userService.TryCanUserAccess(cardId));
        }


        [HttpPost]
        public IActionResult SingUp([FromBody] UserSingUpRequest userRequest) => Ok(_userService.SingUp(userRequest));

        [HttpPut("/api/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UserUpdateRequest userRequest) => Ok(_userService.UpdateUser(id, userRequest));

        [HttpDelete]
        public IActionResult Delete([FromRoute] int id) => Ok(_userService.DeleteUser(id));

        [HttpGet("payment/{id}/{token}")]
        public IActionResult InserPaymentToken([FromRoute] int id, [FromRoute] string token) 
        {
            _userService.InserPaymentToken(id, token);
            return Ok(); 
        }

    }
}
