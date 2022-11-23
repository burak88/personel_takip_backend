using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IUserService
    {
        void UserAdd(User user);
        void UserDelete(User user);
        void UserUpdate(User user);
        List<User> GetById(int id);
        List<User> GetList();
        List<UserDetailDto> GetUserDetail();
    }
}
