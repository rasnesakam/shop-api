﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_app.entity
{
    public class Role: IdentityRole<Guid>
    {
        public DateTime Created { get; set; }
    }
}
