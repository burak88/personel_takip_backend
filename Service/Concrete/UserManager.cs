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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetById(int id)
        {
            return _userDal.List(x=>x.UserId==id);
        }

        public List<User> GetList()
        {
           return _userDal.GetAll();
        }

        public List<UserDetailDto> GetUserDetail()
        {
            return _userDal.GetUserDetail();
        }

        public void UserAdd(User user)
        {
            _userDal.Add(user);
        }

        public void UserDelete(User user)
        {
            _userDal.Delete(user);
        }

        public void UserUpdate(User user)
        {
            _userDal.Update(user);
        }
    }
}
