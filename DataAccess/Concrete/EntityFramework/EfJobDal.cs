using DataAccess.Abstract;
using DataAccess.Concrete.Repository;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfJobDal : GenericRepository<Job>, IJobDal
    {
        public List<JobDetailDto> GetJobDetails(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var result = from j in context.Jobs
                             join u in context.Users
                             on j.UserId equals u.UserId
                             join w in context.WorkTypes
                             on j.WorkTypeId equals w.WorkTypeId
                             select new JobDetailDto
                             {
                                 JobId = j.JobId,
                                 ProjectName = j.ProjectName,
                                 Description = j.Description,
                                 Status = j.Status,
                                 Date = j.Date,
                                 Name = u.Name,
                                 UserId = j.UserId,
                                 WorkTypeName = w.WorkTypeName
                             };
                return result.Where(x=>x.UserId == id).ToList();
            }
        }
    }
}
