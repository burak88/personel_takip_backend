using DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Concrete;

namespace IoTechBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class JobController : ControllerBase
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        AppDbContext context = new AppDbContext();



        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = jobManager.GetJobDetails(id);
            return Ok(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = jobManager.GetList();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Job job)
        {
            jobManager.JobAdd(job);

            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update(Job job)
        {
            jobManager.JobUpdate(job);
            var result = jobManager.GetJobDetails(job.UserId);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var job = context.Jobs.Find(id);

            if (job == null)
                return NotFound();
            jobManager.JobDelete(job);
            var result = jobManager.GetJobDetails(job.UserId);

            return Ok(result);
        }

    }
}
