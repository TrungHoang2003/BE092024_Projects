using System;

namespace BaiTapBuoi8
{
    public class Circle : Geometry
    {
        private double radius;

        public Circle(double radius) : base("hinh tron")
        {
           this.radius = radius; 
        }

        protected override double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        protected override double getArea()
        {
            return Math.PI*(radius * radius);
        }
    }
}