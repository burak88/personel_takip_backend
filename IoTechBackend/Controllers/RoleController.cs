using DataAccess.Concrete.EntityFramework;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Service.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace IoTechBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class RoleController : ControllerBase
    {
        RoleManager roleManager = new RoleManager(new EfRoleDal());
        AppDbContext context = new AppDbContext();

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = roleManager.GetList();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Role role)
        {
            roleManager.RoleAdd(role);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update(Role role)
        {
            roleManager.RoleUpdate(role);
            return Ok();
        }
    }
}
