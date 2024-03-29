﻿using Microsoft.EntityFrameworkCore;
using shop_app.data.Abstract;
using shop_app.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_app.data.Concrete.EfCore
{
    public class EfCoreAddressRepository : EfCoreRepositoryBase<Address>, IAddressRepository
    {
        public EfCoreAddressRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
