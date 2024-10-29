using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess.Structs
{
    /*Một công ty có nhu cầu số hoá quản lý công nợ   Một hoá đơn có các thông tin :
     * Mã hoá đơn , Mã khách hàng, Ngày xuất hoá đơn , tổng tiền ,tổng tiền nợ 
1.Tạo Struct để lưu trữ danh sách hoá đơn trên
2.thực hiện import hoá đơn lên hệ thống bằng file excel 
3.Thực hiện lưu lịch sử tương tác của từng hoá đơn
    ( tương tác bằng các hình thức : gọi điện,gửi mail, gặp trực tiếp khách hàng) 
4. Thực hiện xuất danh sách lịch sử tương tác với hoá đơn của các nhân viên trong công ty
    ra file excel theo tuần ,theo tháng*/
    public struct HoaDon
    {
        public string maHoaDon { get; set; }
        public string maKhachHang { get; set; }
        public DateTime ngayXuatHD { get; set; }
        public float tongTien { get; set; }
        public float tongTienNo { get; set; }
        public HoaDon(string mahd, string makh, DateTime ngayxuat, float tongtien, float tongtienno)
        {
            maHoaDon = mahd;
            maKhachHang = makh;
            ngayXuatHD = ngayxuat;
            tongTien = tongtien;
            tongTienNo = tongtienno;
        }
        public string display()
        {
            return "Ma hoa don: " + maHoaDon + "| Ma khach hang: " + maKhachHang
                + "| Ngay xuat hoa don: " + ngayXuatHD + "| Tong tien: " + tongTien +
                "| Tong tien no: " + tongTienNo;
        }
    }
}
