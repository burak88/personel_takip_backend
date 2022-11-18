using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IRoleService
    {
        void RoleAdd(Role role);
        void RoleDelete(Role role);
        void RoleUpdate(Role role);
        Role GetById(int id);
        List<Role> GetList();
    }
}
