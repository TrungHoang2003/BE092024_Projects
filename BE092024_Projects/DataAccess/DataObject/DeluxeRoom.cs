namespace DataAccess.DataObject
{
    public class DeluxeRoom: Room
    {
        protected internal DeluxeRoom(int roomNumber) : base(roomNumber)
        {
            roomType = "Deluxe Room";
        }
    }
}