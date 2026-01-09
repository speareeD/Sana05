namespace Program
{
    public class Truck : Vehicle
    {
        protected double LoadCapacity;
        protected int NumberOfAxles;

        public Truck(string brand, string model, int year, double price, double loadCapacity, int numberOfAxles)
            : base(brand, model, year, price)
        {
            LoadCapacity = loadCapacity;
            NumberOfAxles = numberOfAxles;
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}. With load capacity of {LoadCapacity} tons and {NumberOfAxles} number of axles";
        }

        public override double CalculateTax()
        {
            return Price * 0.02 + LoadCapacity * 1000;
        }

        public override int GetMaxSpeed()
        {
            return 120;
        }
    }
}
