﻿using DataAccess.Abstract;
using DataAccess.Concrete.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRoleDal : GenericRepository<Role>, IRoleDal
    {
    }
}
