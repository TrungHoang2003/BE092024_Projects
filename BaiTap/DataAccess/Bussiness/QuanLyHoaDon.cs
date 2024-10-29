using Common;
using DataAccess.Structs;
using System;
using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;

namespace DataAccess.Bussiness
{

    public class QuanLyHoaDon
    {
        public HoaDon nhapHoaDon(ref HoaDon hd)
        {
            Console.Write("Nhap ma hoa don: ");
            hd.maHoaDon = Function.nhapString(hd.maHoaDon);

            Console.Write("Nhap ma khach hang: ");
            hd.maKhachHang = Function.nhapString(hd.maKhachHang);

            Console.Write("Nhap ngay xuat (dd//MM/yyyy): ");
            hd.ngayXuatHD = Function.nhapDateTime(hd.ngayXuatHD);

            Console.Write("Nhap tong tien: ");
            hd.tongTien = Function.nhapSo(hd.tongTien);

            Console.Write("Nhap tong tien no: ");
            hd.tongTienNo = Function.nhapSo(hd.tongTienNo);

            return hd;
        }

        public void exportDSHoaDonExcel()
        {
            string filePath = @"C:\\Users\\trung\\OneDrive\\Desktop\\Quản lý công nợ.xlsx";
            int n = 0;
            Console.Write("Nhap so luong hoa don: ");
            n = Function.nhapSo(n);

            List<HoaDon> dsHD = new List<HoaDon>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap hoa don thu " + (i + 1) + ": ");
                HoaDon hd = new HoaDon();
                QuanLyHoaDon quanLyHoaDon = new QuanLyHoaDon();
                quanLyHoaDon.nhapHoaDon(ref hd);
                dsHD.Add(hd);
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                int row = 2;
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách hóa đơn");

                worksheet.Cells[1, 1].Value = "Mã hóa đơn";
                worksheet.Cells[1, 2].Value = "Mã khách hàng";
                worksheet.Cells[1, 3].Value = "Ngày xuất";
                worksheet.Cells[1, 4].Value = "Tổng tiền";
                worksheet.Cells[1, 5].Value = "Tổng tiền nợ";

                foreach (var hd in dsHD)
                {
                    worksheet.Cells[row, 1].Value = hd.maHoaDon;
                    worksheet.Cells[row, 2].Value = hd.maKhachHang;
                    worksheet.Cells[row, 3].Value = hd.ngayXuatHD.ToString("dd/MM/yyy");
                    worksheet.Cells[row, 4].Value = hd.tongTien;
                    worksheet.Cells[row, 5].Value = hd.tongTienNo;

                    row++;
                }

                FileInfo file = new FileInfo(filePath);
                package.SaveAs(file);
            }
        }

        public void importDSHoaDonExcel()
        {
            string filePath = @"C:\\Users\\trung\\OneDrive\\Desktop\\Quản lý công nợ.xlsx";
            var file = new FileInfo(filePath);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(file))
            {
                var worksheet = package.Workbook.Worksheets["Danh sách hóa đơn"];

                for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    var maHD = worksheet.Cells[row, 1].Text;
                    var maKH = worksheet.Cells[row, 2].Text;
                    var ngay = worksheet.Cells[row, 3].Text;
                    var tongTien = worksheet.Cells[row, 4].Text;
                    var tongTienNo = worksheet.Cells[row, 5].Text;

                    Console.WriteLine("\nMa hoa don: " + maHD + " |Ma khach hang:" + maKH + " |Ngay xuat: " + ngay + " |Tong tien: "
                        + tongTien + " |Tong tien no: " + tongTienNo);
                }

            }
        }
    }
}
