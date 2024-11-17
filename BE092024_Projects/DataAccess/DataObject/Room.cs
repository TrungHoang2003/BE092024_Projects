namespace DataAccess.DataObject
{
    public abstract class Room
    {
        protected string roomType { get; set; }
        protected internal int roomNumber { get; set; }
        protected internal bool isAvailable { get; set; }

        protected Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
            isAvailable = true;
        }
    }
}