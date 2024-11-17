using System;
using System.IO;
using System.Linq;
using DataAccess.DataObject;
using DataAccess.Interface;
using OfficeOpenXml;

namespace DataAccess.Bussiness
{
    public class ProcessManager : IProcess
    {
        private const string filePath = @"C:\Users\trung\OneDrive\Desktop\BaiTapBuoi9.xlsx";
        
        public Process addProcess()
        {
            Process process = new Process();

            Console.Write("Nhap ma process: ");
            process.Id = Function.nhapString(process.Id);
            Console.Write("Nhap ten: ");
           process.Name =  Function.nhapString(process.Name);
            Console.Write("Nhap gia: ");
            process.price = Function.nhapSo(process.price);

            return process;
        }

        public void addProcessIntoExcel(Process process)
        {
            if (!ExcelManager.checkExistWorkSheet("Process"))
                Console.WriteLine("Sheet Process khong ton tai");
            else
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var workSheet = package.Workbook.Worksheets["Process"];
                    int row = ExcelManager.rowCount("Process") + 1;
                    
                    workSheet.Cells[row, 1].Value = process.Id;
                    workSheet.Cells[row, 2].Value = process.Name;
                    workSheet.Cells[row, 3].Value = process.price;
                    package.SaveAs(new FileInfo(filePath));
                }
            }
        }
    }
}