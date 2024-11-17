using System.Collections.Generic;
using System.Linq;
using DataAccess.Interface;

namespace DataAccess.DataObject
{
    public class RoomRespository: IRoomRepository
    {
        private readonly List<Room> _rooms = new List<Room>
        {
            new StandardRoom(101),
            new DeluxeRoom(102),
            new SuiteRoom(103)
        };

        public Room GetRoomByNumber(int roomNumber)
        {
           return _rooms.FirstOrDefault(r => r.roomNumber == roomNumber); 
        }

        public void UpdateRoomAvailability(int roomNumber, bool isAvailable)
        {
            Room room = GetRoomByNumber(roomNumber);
            if (room != null)
            {
                room.isAvailable = isAvailable;
            }
        }
    }
}