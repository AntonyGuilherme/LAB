using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api")]
    public class AuthenticationController : Controller
    {

        //private readonly IAuthenticationService _authenticationService;

        //public AuthenticationController(IAuthenticationService authenticatipnService)
        //{
        //    _authenticationService = authenticatipnService;
        //}

        //[HttpPost("signin")]
        //public IActionResult SingIn([FromBody] LoginRequest login)
        //{
        //    try
        //    {
        //        var response = _authenticationService.SignIn(login);
        //        return Ok(response);
        //    }
        //    catch (DomainException ex)
        //    {
        //        var error = _errorResponse.CreateErrorResponse(ex.Source, ex.ErrorMessage);
        //        return BadRequest(error);
        //    }
        //}

    }
}
