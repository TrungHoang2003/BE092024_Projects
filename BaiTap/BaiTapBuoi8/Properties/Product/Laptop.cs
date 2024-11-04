namespace BaiTapBuoi8
{
    public class Laptop: Product
    {
        private double SoftwareFee{get;set;}

        public Laptop(string name, double baseprice, double softwareFee) : base(name, baseprice, "Laptop")
        {
            SoftwareFee = softwareFee;
        }

        protected override double calculatePrice()
        {
            return BasePrice + SoftwareFee; 
        }
    }
}