using DataAccess.Bussiness;
using DataAccess.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi5
{
    public class Program
    {
        static void Main(string[] args)
        {
            QuanLyHoaDon quanLyHoaDon = new QuanLyHoaDon();
            QuanLyLichSuTuongTac quanLyLichSuTuongTac = new QuanLyLichSuTuongTac();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n======================MENU==========================");
                Console.WriteLine("1. Nhap danh sach hoa don va luu vao file Excel.");
                Console.WriteLine("2. Import danh sach hoa don tu file Excel.");
                Console.WriteLine("3. Xuat danh sach lich su tuong tac ra file excel theo tuan/ thang");
                
                
                int choice = 0;
                Console.Write("- Nhap lua chon cua ban: ");
                choice = Function.nhapSo(choice);
                switch (choice)
                {
                    case 1:
                        quanLyHoaDon.exportDSHoaDonExcel();
                        break;
                    case 2:
                        quanLyHoaDon.importDSHoaDonExcel();
                        break;
                    case 3:
                        quanLyLichSuTuongTac.nhapLichSuTuongTac();
                        quanLyLichSuTuongTac.ExportLichSuTuongTacTheoThang();
                        quanLyLichSuTuongTac.ExportLichSuTuongTacTheoTuan();
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
