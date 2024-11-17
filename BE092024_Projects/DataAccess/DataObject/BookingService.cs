using System;
using DataAccess.Interface;

namespace DataAccess.DataObject
{
    public class BookingService: IBookingCreation
    {
        private readonly IRoomRepository _roomRepository;

        public BookingService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public Booking CreateBooking(string customerName, int roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
           Room room = _roomRepository.GetRoomByNumber(roomNumber);

           if (room == null)
           {
               throw new Exception("Phòng không tồn tại");
           } if (!room.isAvailable)
           {
               throw new Exception("Phòng hiện tại không trống");
           }

           var booking = new Booking(
               bookingId: new Random().Next(1, 1000),
               customerName: customerName,
               roomNumber: roomNumber,
               checkInDate: checkInDate,
               checkOutDate: checkOutDate
           );
           
           _roomRepository.UpdateRoomAvailability(roomNumber, room.isAvailable);
           
           return booking;
        }
    }
}