namespace BaiTapBuoi8
{
    public class Phone : Product
    {
        private double WarrantyFee{get;set;}

        public Phone(string name, double basePrice, double warrantyFee) : base(name, basePrice, "Phone")
        {
            this.WarrantyFee = warrantyFee;
        }

        protected override double calculatePrice()
        {
           return BasePrice + WarrantyFee; 
        }
    }
}