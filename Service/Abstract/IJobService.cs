using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IJobService
    {
        void JobAdd(Job job);
        void JobDelete(Job job);
        void JobUpdate(Job job);
        Job GetById(int id);
        List<Job> GetList();
        JobDetailDto GetJobDetails(int id);
    }
}
