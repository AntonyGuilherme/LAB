using Microsoft.AspNetCore.Mvc;

namespace CatracaInteligenteAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CratracaInteligenteController : ControllerBase
    {
        private static readonly CatracaInteligenteService _service = new CatracaInteligenteService();

        public class ModelT
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string EnrollNumber { get; set; }
        }

        [HttpPost()]
        public ActionResult SingUp([FromBody] ModelT model) 
        {
            _service.SingUp(model.Name, model.Email, model.EnrollNumber, model.Password);

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

        public class PaymentTokenModel 
        {
            public int UserId { get; set; }
            public string PaymentToken { get; set; }
        }

        [HttpPut()]
        public ActionResult InsertPaymentToken([FromBody] PaymentTokenModel payment)
        {
            _service.InsertPaymentToken(payment.UserId, payment.PaymentToken);

            return Ok();
        }

        [HttpGet()]
        public ActionResult CanUserAccessCollegeRestaurant(string cardId)
        {
            var canUserAccessCollegeRestaurant = _service.CanUserAccessCollegeRestaurant(cardId);

            return Ok(canUserAccessCollegeRestaurant);
        }

    }
}