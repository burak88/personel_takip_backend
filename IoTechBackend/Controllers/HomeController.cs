using DataAccess;
using Entity.Concrete;
using IoTechBackend.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IoTechBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        AppDbContext context = new AppDbContext();
        [HttpPost("action")]
        public IActionResult Login(User user)
        {
            var data = context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            if (data != null)
            {
                return Created("", new BuildToken().CreateToken());

            }

            else
            {
                return BadRequest();
            }
        }
    }
}
