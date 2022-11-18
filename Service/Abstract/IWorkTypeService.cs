using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IWorkTypeService
    {
        void WorkTypeAdd(WorkType workType);
        void WorkTypeDelete(WorkType workType);
        void WorkTypeUpdate(WorkType workType);
        WorkType GetById(int id);
        List<WorkType> GetList();
    }
}
