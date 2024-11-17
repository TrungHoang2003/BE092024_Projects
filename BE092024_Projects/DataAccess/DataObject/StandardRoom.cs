namespace DataAccess.DataObject
{
    public class StandardRoom: Room
    {
        protected internal StandardRoom(int roomNumber) : base(roomNumber)
        {
            roomType = "Standard";
        }
    }
}