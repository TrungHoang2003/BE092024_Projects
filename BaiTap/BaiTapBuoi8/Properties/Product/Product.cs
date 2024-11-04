using System;
using System.Security.Cryptography;

namespace BaiTapBuoi8
{
    public abstract class Product
    {
        private string Name { get; set; }
        protected double BasePrice { get; set; }
        private string Category { get; set; }

        protected Product(string name, double basePrice, string category)
        {
            Name = name;
            BasePrice = basePrice;
            Category = category;
        }

        public virtual void display()
        {
            Console.WriteLine($"Ten san pham:  {Name}");
            Console.WriteLine($"Thong tin:  {Category}");
            Console.WriteLine($"Gia tri:  {calculatePrice()}");
        }
        protected abstract double calculatePrice();
    }
}