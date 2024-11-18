using System.Collections.Generic;
using DataAccess.DataObject;

namespace DataAccess.Interface;

public interface IRoomRepository
{
    List<Room> GetAllRooms();
    Room getRoomByNumber(int roomNumber);
    void updateRoomAvailability(int roomNumber, bool isAvailable);
    bool checkRoomAvailability(int roomNumber);
    void getRoomDetails();
}