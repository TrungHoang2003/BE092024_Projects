using DataAccess.DataObject;

namespace DataAccess.Interface;

public interface IBookingCreation
{
    Booking createBooking(Booking booking);
}