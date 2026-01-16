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
            if (year < 1886)
            {
                throw new Exception("Year cannot be less than 1886");
            }
            else
            {
                Year = year;
            }
            Price = price;
        }

        public virtual string DisplayInfo()
        {
            return $"{Year} {Brand} {Model}\nPrice: ${Price}";
        }

        public virtual double CalculateTax()
        {
            return Price * 0.01;
        }

        public virtual int GetMaxSpeed()
        {
            return 100;
        }
        public virtual string GetShortName()
        {
            return $"{Brand} {Model}";
        }
    }
}
