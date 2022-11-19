using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class JobManager : IJobService
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public Job GetById(int id)
        {
            return _jobDal.Get(p => p.JobId == id);
        }

        public List<JobDetailDto> GetJobDetails(int id)
        {
            return _jobDal.GetJobDetails(id);
        }

        public List<Job> GetList()
        {
            return _jobDal.GetAll();
        }

        public void JobAdd(Job job)
        {
            _jobDal.Add(job);
        }

        public void JobDelete(Job job)
        {
            _jobDal.Delete(job);
        }

        public void JobUpdate(Job job)
        {
           _jobDal.Update(job);
        }
    }
}
