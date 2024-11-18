using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.DataObject;
using DataAccess.Interface;

namespace DataAccess.Bussiness;

public class RoomRespository : IRoomRepository
{
    private readonly List<Room> _rooms =
    [
        new DeluxeRoom(101),
        new StandardRoom(102),
        new SuiteRoom(103)
    ];

    public List<Room> GetAllRooms()
    {
        return _rooms;
    }

    public Room getRoomByNumber(int roomNumber)
    {
        return _rooms.FirstOrDefault(r => r.roomNumber == roomNumber);
    }

    public void updateRoomAvailability(int roomNumber, bool isAvailable)
    {
        var room = getRoomByNumber(roomNumber);
        if (room != null) room.isAvailable = isAvailable;
    }

    public bool checkRoomAvailability(int roomNumber)
    {
        var room = getRoomByNumber(roomNumber);
        if (room == null || !room.isAvailable)
            return false;
        return true;
    }

    public void getRoomDetails()
    {
        foreach (var room in _rooms)
            Console.WriteLine($"Phong: {room.roomNumber}," +
                              $" Loai: {room.roomType}," +
                              $" Trang thai: {(room.isAvailable ? "Con trong" : "Da dat")}");
    }
}