using System;

namespace DataAccess.DataObject
{
    public class Booking
    { public int bookingId{get;set;}
       public string cutomerName{get;set;}
       public int roomNumber{get;set;}
       DateTime checkInDate{get;set;}
       DateTime checkOutDate{get;set;}
       
        public Booking(int bookingId, string customerName, int roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            this.bookingId = bookingId;
            this.cutomerName = customerName;
            this.roomNumber = roomNumber;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
        }
    }
}