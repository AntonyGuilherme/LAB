using Microsoft.AspNetCore.Mvc;

namespace CatracaInteligenteAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CratracaInteligenteController : ControllerBase
    {
        private static readonly CatracaInteligenteService _service = new CatracaInteligenteService();


        [HttpPost()]
        public ActionResult SingUp(string name, string email, string enrollNumber, string password) 
        {
            _service.SingUp(name, email, enrollNumber, password);

            return Ok();
        }

        [HttpGet()]
        public ActionResult SingIn(string email, string password)
        {
            var model = _service.SingIn(email, password);

            return Ok(model);
        }

        [HttpPatch()]
        public ActionResult ToggleCardUsability(long userId)
        {
            _service.ToggleCardUsability(userId);

            return Ok();
        }

        [HttpPut()]
        public ActionResult InsertPaymentToken(long userId, string paymentToken)
        {
            _service.InsertPaymentToken(userId, paymentToken);

            return Ok();
        }

        [HttpGet()]
        public ActionResult CanUserAccessCollegeRestaurant(long userId)
        {
            var canUserAccessCollegeRestaurant = _service.CanUserAccessCollegeRestaurant(userId);

            return Ok(canUserAccessCollegeRestaurant);
        }

    }
}