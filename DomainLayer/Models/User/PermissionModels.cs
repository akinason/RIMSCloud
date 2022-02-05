﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class RoleModel : IRoleModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Key { get; set; }
    }

}
