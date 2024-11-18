using System;
using DataAccess.Bussiness;
using DataAccess.DataObject;

namespace BaiTap
{
    public class Bai10 : IBaiTap
    {
        public void Run()
        {
            var roomRepository = new RoomRespository();
            var bookingService = new BookingService(roomRepository);
            var booking = new Booking();

            Console.WriteLine("=============Bai 10=============");
            Console.WriteLine("1. Tao dat phong.");
            Console.WriteLine("2. Xem danh sach phong hien tai.");
            Console.WriteLine("3. Dong chuong trinh.");

            string choice = null;
            var isRunning = true;
            while (isRunning)
            {
                Console.Write("\nNhap lua chon cua ban: ");
                choice = Function.nhapString(choice);
                switch (choice)
                {
                    case "1":
                        bookingService.createBooking(booking);
                        bookingService.bookingDetail(booking);
                        break;
                    case "2":
                        roomRepository.getRoomDetails();
                        break;
                    case "3":
                        isRunning = false;
                        break;
                }
            }
        }
    }
}