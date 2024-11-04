using System;

namespace BaiTapBuoi8
{
    public class PartTime_Employee: Employee
    {
        private double wage;
        private double hours;

        public PartTime_Employee(string name, string id, double wage, double hours) : base(name, id,
            "PartTime")
        {
            this.wage = wage;
            this.hours = hours;
        }

        protected override double getSalary()
        {
            return wage * hours;
        }
    }
}