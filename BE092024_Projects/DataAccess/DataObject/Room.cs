namespace DataAccess.DataObject;

public abstract class Room
{
    protected Room(int roomNumber)
    {
        this.roomNumber = roomNumber;
        isAvailable = true;
    }

    public string roomType { get; set; }
    public int roomNumber { get; set; }
    public bool isAvailable { get; set; }
}

public class DeluxeRoom : Room
{
    protected internal DeluxeRoom(int roomNumber) : base(roomNumber)
    {
        roomType = "Deluxe Room";
    }
}

public class StandardRoom : Room
{
    protected internal StandardRoom(int roomNumber) : base(roomNumber)
    {
        roomType = "Standard";
    }
}

public class SuiteRoom : Room
{
    protected internal SuiteRoom(int roomNumber) : base(roomNumber)
    {
        roomType = "SuiteRoom";
    }
}