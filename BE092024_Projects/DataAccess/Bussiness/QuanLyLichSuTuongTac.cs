using DataAccess.Structs;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Bussiness
{
    public class QuanLyLichSuTuongTac
    {
        public void nhapLichSuTuongTac()
        {
            var quanLyHoaDon = new QuanLyHoaDon();
            var listLichSuTuongTac = new List<LichSuTuongTac>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            const string filePath = @"C:\\Users\\trung\\OneDrive\\Desktop\\Quản lý công nợ.xlsx";

            var file = new FileInfo(filePath);
            using (var package = new ExcelPackage(file))
            {
                var worksheet = package.Workbook.Worksheets["Danh sách hóa đơn"];
                var rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    LichSuTuongTac lichSu = new LichSuTuongTac();

                    lichSu.maHD = worksheet.Cells[row, 1].Text;
                    Console.WriteLine("\nNhap lich su tuong tac cho hoa don " + lichSu.maHD + ": ");

                    Console.Write("Nhap ten nhan vien: ");
                    lichSu.tenNhanVien = Function.nhapString(lichSu.tenNhanVien);

                    Console.Write("Nhap hinh thuc tuong tac: ");
                    lichSu.hinhThucTT = Function.nhapString(lichSu.hinhThucTT);

                    Console.Write("Nhap ngay tuong tac: ");
                    lichSu.ngayTT = Function.nhapDateTime(lichSu.ngayTT);
                    listLichSuTuongTac.Add(lichSu);
                }

                foreach (var tuongTac in listLichSuTuongTac)
                {
                    Console.WriteLine("\nMa hoa don: " + tuongTac.maHD + " |Ten nhan vien: " + tuongTac.tenNhanVien + " |Hinh thuc tuong tac: "
                        + tuongTac.hinhThucTT + " |Ngay tuong tac: " + tuongTac.ngayTT);
                }
            }

        }
        public void ExportLichSuTuongTacTheoThang()
        {
            List<LichSuTuongTac> danhSachTuongTac = new List<LichSuTuongTac>();
            var filteredList = danhSachTuongTac
                                .Where(t => t.ngayTT >= DateTime.Now.AddMonths(-1) && t.ngayTT <= DateTime.Now)
                                .ToList();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\\Users\\trung\\OneDrive\\Desktop\\Quản lý công nợ.xlsx";

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("LichSuTuongTacMonthly");

                worksheet.Cells[1, 1].Value = "Mã Hóa Đơn";
                worksheet.Cells[1, 2].Value = "Hình Thức Tương Tác";
                worksheet.Cells[1, 3].Value = "Ngày Tương Tác";
                int row = 2;
                foreach (var item in filteredList)
                {
                    worksheet.Cells[row, 1].Value = item.maHD;
                    worksheet.Cells[row, 2].Value = item.tenNhanVien;
                    worksheet.Cells[row, 3].Value = item.hinhThucTT;
                    worksheet.Cells[row, 4].Value = item.ngayTT.ToString("dd/MM/yyyy");
                    row++;
                }

                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }

        public void ExportLichSuTuongTacTheoTuan()
        {
            List<LichSuTuongTac> danhSachTuongTac = new List<LichSuTuongTac>();
            var filteredList = danhSachTuongTac
                                .Where(t => t.ngayTT >= DateTime.Now.AddDays(-7) && t.ngayTT <= DateTime.Now)
                                .ToList();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"C:\\Users\\trung\\OneDrive\\Desktop\\Quản lý công nợ.xlsx";

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("LichSuTuongTacWeekly");

                worksheet.Cells[1, 1].Value = "Mã Hóa Đơn";
                worksheet.Cells[1, 2].Value = "Hình Thức Tương Tác";
                worksheet.Cells[1, 3].Value = "Ngày Tương Tác";

                int row = 2;
                foreach (var item in filteredList)
                {
                    worksheet.Cells[row, 1].Value = item.maHD;
                    worksheet.Cells[row, 2].Value = item.tenNhanVien;
                    worksheet.Cells[row, 3].Value = item.hinhThucTT;
                    worksheet.Cells[row, 4].Value = item.ngayTT.ToString("dd/MM/yyyy");
                    row++;
                }

                FileInfo fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
        }
    }
}
