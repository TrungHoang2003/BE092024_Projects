using System;

namespace BaiTap
{
    public class MainEntryPoint
    {
        public static void Main(string[] args)
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "9":
                    Bai9 bai9 = new Bai9();
                    bai9.Run();
                    break;
                case "10":
                    Bai10 bai10 = new Bai10();
                    bai10.Run();
                    break;
                case "11":
                    Bai11 bai11 = new Bai11();
                    bai11.Run();
                    break;
            } 
        }
    }
}