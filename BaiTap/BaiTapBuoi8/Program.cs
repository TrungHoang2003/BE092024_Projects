using System;
using System.Collections.Generic;

namespace BaiTapBuoi8
{
  internal class Program
  {
        public static void Main(string[] args)
        {
            List<Geometry> listGeometries = new List<Geometry>()
            {
                new Circle(5),
                new Rectangle(10,5)
            };
            foreach (var geometry in listGeometries)
            {
                geometry.display();
                Console.WriteLine();
            }
            
            
            List<Employee> listEmployee = new List<Employee>
            {
                new PartTime_Employee("Trung", "NV01", 26, 130),
                new FullTime_Employee("Tu", "NV02"),
            };
            foreach (var employee in listEmployee)
            {
                employee.display();
                Console.WriteLine();
            }

            List<Product> listProducts = new List<Product>
            {
                new Book("De men phieu luu ky" , 25, 10),
                new Laptop("Macbook M3", 200, 30),
                new Phone("Iphone 15 Plus", 10, 30)
            };
            foreach (var product in listProducts)
            {
               product.display();
               Console.WriteLine();
            }
        }
    }
}