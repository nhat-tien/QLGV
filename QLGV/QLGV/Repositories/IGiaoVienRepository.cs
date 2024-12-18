﻿using QLGV.Models;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories
{
    public interface IGiaoVienRepository
    {
        IEnumerable<GiaoVienModel> Find(BaseFindCreterias creterias);
        
        int Add(GiaoVienModel model);
        int Delete(int id);
        int Delete(int[] id);
        int Update(GiaoVienModel model);
        int Count();
        int Count(string column, string value);

        GiaoVienModel FindById(int id);
        GiaoVienModel FindByIdIncludeOne<BoMonModel>(int id);

        IEnumerable<GiaoVienModel> IncludeBoMon(IEnumerable<GiaoVienModel> giaoVien);
        GiaoVienModel IncludeBoMon(GiaoVienModel model);
        GiaoVienModel IncludeChucVu(GiaoVienModel model);
        GiaoVienModel IncludeBangLuong(GiaoVienModel model);
        IEnumerable<GiaoVienModel> IncludeBangLuong(IEnumerable<GiaoVienModel> model);
        IEnumerable<GiaoVienModel> IncludeChucVu(IEnumerable<GiaoVienModel> giaoVien);
    }
}
