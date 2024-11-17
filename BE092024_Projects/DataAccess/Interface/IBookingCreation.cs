using System;
using DataAccess.DataObject;

namespace DataAccess.Interface
{
    public interface IBookingCreation
    {
         Booking CreateBooking (string customerName, int roomNumber, DateTime checkInDate, DateTime checkOutDate);
    }
}