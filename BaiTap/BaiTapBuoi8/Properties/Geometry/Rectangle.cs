namespace BaiTapBuoi8
{
    public class Rectangle : Geometry
    {
        private double width;
        private double height;

        public Rectangle(double width, double height) : base("hinh chu nhat")
        {
            this.width = width;
            this.height = height;
        }

        protected override double getPerimeter()
        {
            return (width + height)*2;
        }

        protected override double getArea()
        {
            return width * height;
        }
    }
}