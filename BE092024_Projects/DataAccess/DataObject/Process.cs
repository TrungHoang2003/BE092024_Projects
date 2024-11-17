using System;
using DataAccess.Bussiness;
using OfficeOpenXml;

namespace DataAccess.DataObject
{
    public class Process
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int price { get; set; }

        public Process(string name, string id, int price)
        {
            this.Name = name;
            this.Id = id;
            this.price = price;
        }

        public Process()
        {
        }
    }

}