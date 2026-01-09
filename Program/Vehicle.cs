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

        public virtual string DisplayInfo()
        {
            return $"{Year} {Brand} {Model} - ${Price}";
        }

        public virtual double CalculateTax()
        {
            return Price * 0.01;
        }

        public virtual string GetMaxSpeed()
        {
            return "100 km/h";
        }
    }
}
