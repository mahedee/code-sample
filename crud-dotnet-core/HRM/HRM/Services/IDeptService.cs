﻿using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Services
{
    public interface IDeptService
    {
        public Task<List<Dept>> GetDepts();
    }
}
