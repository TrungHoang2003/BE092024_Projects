using System;
using DataAccess.DataObject;
using DataAccess.Interface;

namespace BaiTap
{
    public class Bai11: IBaiTap
    {
        public void Run()
        {
            IRoomRepository roomRepository = new RoomRespository();
            IBookingCreation bookingService = new BookingService(roomRepository);

            try
            {
                Booking booking = bookingService.CreateBooking(
                    customerName: "Trung",
                    roomNumber: 101,
                    checkInDate: DateTime.Now,
                    checkOutDate: DateTime.Now.AddDays(2)
                );
                Console.WriteLine($"Đặt phòng thành công, Mã phòng :{booking.bookingId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}