﻿using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories
{
    internal interface IGiaoVienRepository
    {
        IEnumerable<GiaoVien> Find();
    }
}
