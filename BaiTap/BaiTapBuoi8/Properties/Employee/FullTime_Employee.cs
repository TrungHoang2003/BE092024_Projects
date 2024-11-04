using System;

namespace BaiTapBuoi8
{
    public class FullTime_Employee: Employee
    {
        public FullTime_Employee(string name, string id ) : base(name, id, "Full Time")
        {
        }

        protected override double getSalary()
        {
            return 10000;
        }
    }
}