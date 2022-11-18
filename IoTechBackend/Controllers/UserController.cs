using DataAccess.Concrete.EntityFramework;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Service.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace IoTechBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class UserController : ControllerBase
    {
        UserManager userManager = new UserManager(new EfUserDal());
        AppDbContext context = new AppDbContext();



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = userManager.GetUserDetail();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            userManager.UserAdd(user);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update(User user)
        {
            userManager.UserUpdate(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var user = context.Users.Find(id);

            if (user == null)
                return NotFound();

            userManager.UserDelete(user);

            return NoContent();
        }

    }
}
