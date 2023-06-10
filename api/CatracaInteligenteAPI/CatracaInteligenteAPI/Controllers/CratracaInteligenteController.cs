using Microsoft.AspNetCore.Mvc;

namespace CatracaInteligenteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CratracaInteligenteController : ControllerBase
    {
        private static readonly CatracaInteligenteService _service = new CatracaInteligenteService();

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return null;
        }

        [HttpPost()]
        public ActionResult SingUp(string name, string email, string enrollNumber, string password) 
        {
            _service.SingUp(name, email, enrollNumber, password);

            return Ok();
        }


    }
}