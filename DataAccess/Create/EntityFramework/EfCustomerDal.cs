﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Create.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,ReCapProjectContext>,ICustomerDal
    {
    }
}
