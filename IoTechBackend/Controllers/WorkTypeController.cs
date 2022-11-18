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

    public class WorkTypeController : ControllerBase
    {
        WorkTypeManager workTypeManager = new WorkTypeManager(new EfWorkTypeDal());
        AppDbContext context = new AppDbContext();



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = workTypeManager.GetList();
            return Ok(result);
        }


        [HttpPost("add")]
        public IActionResult Add(WorkType workType)
        {
            workTypeManager.WorkTypeAdd(workType);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update(WorkType workType)
        {
            workTypeManager.WorkTypeUpdate(workType);
            return Ok();
        }
    }
}
