﻿using QLGV.Repositories;
using QLGV.Repositories.SqlServer;
using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Repositories.Creterias;

namespace QLGV.Services
{
    public class GiaoVienService
    {
        private readonly IGiaoVienRepository _repository;
        public GiaoVienService()
        {
            _repository = new GiaoVienRepository();
        }

        public IEnumerable<GiaoVienModel> GetAll()
        {
            var giaoViens = _repository.FindIncludeBoMon(BaseFindCreterias.Empty());

            return giaoViens;
        }
    }
}
