using DataAccess.DataObject;

namespace DataAccess.Interface
{
    public interface IRoomRepository
    {
        Room GetRoomByNumber(int roomNumber);
         void UpdateRoomAvailability(int roomNumber, bool isAvailable);
    }
}