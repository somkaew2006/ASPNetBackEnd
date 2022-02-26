using ASPNETLIVE.Services.ThaiDate;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETLIVE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IThaiDate _thaidate;
        public HomeController(IThaiDate thaiDate)
        {
            _thaidate = thaiDate;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var myThaiDate = _thaidate.ShowThaiDate();
            return Ok(new {message= $"Hello MY API {myThaiDate}"});
            
        }
    }
}
