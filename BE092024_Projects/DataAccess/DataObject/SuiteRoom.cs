namespace DataAccess.DataObject
{
    public class SuiteRoom: Room
    {
        protected internal SuiteRoom(int roomNumber) : base(roomNumber)
        {
            roomType="SuiteRoom";
        }
    }
}