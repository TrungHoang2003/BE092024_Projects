using Common;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace DataAccess.Bussiness
{
    public class Function
    {
        public static int nhapSo(int input)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("So khong hop le.");
                break;
            }
            return input;
        }
        public static float nhapSo(float input)
        {
            while (true)
            {
                if (!Single.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("So khong hop le.");
                break;
            }
            return input;
        }
        public static string nhapString(string input)
        {
            input = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(input))
                    Console.WriteLine("Chuoi khong duoc rong.");
                else if (Validation.ContainsHtml(input))
                    Console.WriteLine("Chuoi khong duoc chua the html.");
                else if (Validation.ContainsSpecialChars(input))
                    Console.WriteLine("Chuoi khong duoc chua ky tu dac biet.");
                break;
            }
            return input;
        }

        public static DateTime nhapDateTime(DateTime input)
        {
            string format = "dd/MM/yyyy";
            while (true)
            {
                if (!DateTime.TryParseExact(Console.ReadLine(), format,
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out input))
                    Console.WriteLine("Khong dung dinh dang.");
                break;
            }
            return input;
        }
    }
}
