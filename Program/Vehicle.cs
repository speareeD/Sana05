namespace Program
{
    public class Vehicle
    {
        protected string Brand;
        protected string Model;
        protected int Year;
        protected double Price;

        public Vehicle(string brand, string model, int year, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

    }
}
