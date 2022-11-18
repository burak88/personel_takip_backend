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
    public class EfUserDal : GenericRepository<User>, IUserDal
    {

        public List<UserDetailDto> GetUserDetail()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var result = from u in context.Users
                             join r in context.Roles
                             on u.RoleId equals r.RoleId
                             select new UserDetailDto
                             {
                                 UserId = u.UserId,
                                 Name = u.Name,
                                 Surname = u.Surname,
                                 Email = u.Email,
                                 Password = u.Password,
                                 RoleName = r.RoleName
                                 
                             };
                return result.ToList();
            }
        }
    }
}
