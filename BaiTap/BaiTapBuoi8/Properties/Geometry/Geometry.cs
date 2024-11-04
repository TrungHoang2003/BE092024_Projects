using System;

namespace BaiTapBuoi8
{
    public abstract class Geometry
    {
        private string category { get; set; }

        protected Geometry(string category)
        {
            this.category = category;
        }

        protected abstract double getPerimeter();
        protected abstract double getArea();

        public virtual void display()
        {
            Console.WriteLine("Chu vi " + category + ": " + getPerimeter());
            Console.WriteLine("Dien tich " + category + ": " + getArea());
        }
    }
}