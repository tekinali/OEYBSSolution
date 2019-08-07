﻿using OEYBS.Core.DataAccess.EntityFramework;
using OEYBS.DataAccess.Abstract;
using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.DataAccess.Concrete.EntityFramework
{
    public class EfUserRoleDal : EfEntityRepositoryBase<UserRole, DatabaseContext>, IUserRoleDal
    {
    }
}
