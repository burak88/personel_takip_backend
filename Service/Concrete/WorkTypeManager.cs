using DataAccess.Abstract;
using Entity.Concrete;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class WorkTypeManager : IWorkTypeService
    {
        IWorkTypeDal _workTypeDal;

        public WorkTypeManager(IWorkTypeDal workTypeDal)
        {
            _workTypeDal = workTypeDal;
        }

        public WorkType GetById(int id)
        {
            return _workTypeDal.Get(p => p.WorkTypeId == id);
        }

        public List<WorkType> GetList()
        {
            return _workTypeDal.GetAll();
        }

        public void WorkTypeAdd(WorkType workType)
        {
            _workTypeDal.Add(workType);
        }

        public void WorkTypeDelete(WorkType workType)
        {
            _workTypeDal.Delete(workType);
        }

        public void WorkTypeUpdate(WorkType workType)
        {
            _workTypeDal.Update(workType);
        }
    }
}
