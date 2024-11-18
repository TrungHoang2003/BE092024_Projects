using System;

namespace DataAccess.DataObject;

public class Booking
{
    public Booking(int bookingId, string customerName, int roomNumber, DateTime checkInDate, DateTime checkOutDate)
    {
        this.bookingId = bookingId;
        this.customerName = customerName;
        this.roomNumber = roomNumber;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
    }

    public Booking()
    {
    }

    public int bookingId { get; set; }
    public string customerName { get; set; }
    public int roomNumber { get; set; }
    public DateTime checkInDate { get; set; }
    public DateTime checkOutDate { get; set; }
}