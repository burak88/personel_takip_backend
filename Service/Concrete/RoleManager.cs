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
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public Role GetById(int id)
        {
           return _roleDal.Get(p=>p.RoleId == id);
        }

        public List<Role> GetList()
        {
            return _roleDal.GetAll();
        }

        public void RoleAdd(Role role)
        {
            _roleDal.Add(role);
        }

        public void RoleDelete(Role role)
        {
            _roleDal.Delete(role);
        }

        public void RoleUpdate(Role role)
        {
            _roleDal.Update(role);
        }
    }
}
