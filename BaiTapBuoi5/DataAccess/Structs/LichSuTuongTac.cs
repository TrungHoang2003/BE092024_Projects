using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Structs
{
    public struct LichSuTuongTac
    {
        public string maHD { get; set; }
        public string tenNhanVien { get; set; }
        public string hinhThucTT { get; set; }
        public DateTime ngayTT { get; set; }

        public LichSuTuongTac(string mahd, string ten, string hinhthuc, DateTime ngay)
        {
            maHD = mahd;
            tenNhanVien = ten;
            hinhThucTT = hinhthuc;
            ngayTT = ngay;
        }
    }

}
