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


    }
}
