using System;
using System.Runtime.InteropServices;

namespace BaiTapBuoi8
{
    public abstract class Employee
    {
        private string name{ get; set; }
        private string id{ get; set; }
        private string position { get; set; }
        
        protected Employee(string name, string id, string postion)
        {
            this.name = name;
            this.id = id;
            this.position = postion;
        }

        protected abstract double getSalary();

        public virtual void display()
        {
            Console.WriteLine("Ten nhan vien: {0}", name);
            Console.WriteLine("Ma nhan vien: {0}", id);
            Console.WriteLine("Vi tri: {0}", position);
            Console.WriteLine("Luong: {0}", getSalary());
        }
        
    }
}