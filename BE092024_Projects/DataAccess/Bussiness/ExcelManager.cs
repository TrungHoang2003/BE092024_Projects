using System;
using System.IO;
using OfficeOpenXml;

namespace DataAccess.Bussiness
{
    public class ExcelManager
    {
        private const string filePath = @"C:\Users\trung\OneDrive\Desktop\BaiTapBuoi9.xlsx";
        public static bool checkExistWorkSheet(string workSheetName)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                    return false;
                foreach (var sheet in package.Workbook.Worksheets)
                    if (sheet.Name == workSheetName)
                        return true;
            }
            return false;
        }
        public static int rowCount(string workSheetName)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                if (!checkExistWorkSheet(workSheetName))
                {
                    Console.WriteLine("Sheet Process khong ton tai.");
                }

                var worksheet = package.Workbook.Worksheets[workSheetName];
                return worksheet.Dimension.End.Row;
            }
        }
    }
}