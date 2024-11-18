using System;
using DataAccess.DataObject;
using DataAccess.Interface;

namespace DataAccess.Bussiness;

public class BookingService(IRoomRepository roomRepository) : IBookingCreation, IBookingCancellation, IBookingDetail
{
    public void CancelBooking(string bookingId)
    {
        throw new NotImplementedException();
    }

    public Booking createBooking(Booking booking)
    {
        Console.Write("Nhap so phong: ");
        booking.roomNumber = Function.nhapSo(booking.roomNumber);
        if (!roomRepository.checkRoomAvailability(booking.roomNumber))
        {
            Console.WriteLine("Phong khong ton tai hoac khong trong.");
        }
        else
        {
            Console.Write("Nhap ten khach hang: ");
            booking.customerName = Function.nhapString(booking.customerName);
            Console.Write("Nhap ngay check in: ");
            booking.checkInDate = Function.nhapDateTime(booking.checkInDate);
            Console.Write("Nhap ngay check out: ");
            booking.checkOutDate = Function.nhapDateTime(booking.checkOutDate);
        }

        roomRepository.updateRoomAvailability(booking.roomNumber, false);
        return booking;
    }

    public void bookingDetail(Booking booking)
    {
        Console.WriteLine(
            $"[Khach hang: {booking.customerName}, " +
            $"So phong: {booking.roomNumber}," +
            $" Ngay check in: {booking.checkInDate:dd/MM/yyyy}," +
            $" Ngay check out: {booking.checkOutDate:dd/MM/yyyy}]");
    }
}