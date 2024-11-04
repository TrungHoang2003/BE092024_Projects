namespace BaiTapBuoi8
{
    public class Book : Product
    {
        private double AuthorRoyalty{get;set;}
        public Book(string name, double basePrice, double authorRoyalty) : base(name, basePrice, "Book")
        {
           this.AuthorRoyalty = authorRoyalty; 
        }

        protected override double calculatePrice()
        {
            return BasePrice + AuthorRoyalty;
        }
    }
}