namespace Program
{
    public class Truck : Vehicle
    {
        protected double LoadCapacity;
        protected int NumberOfAxles;

        public Truck(string brand, string model, int year, double price, double loadCapacity, int numberOfAxles)
            : base(brand, model, year, price)
        {
            if (loadCapacity < 0)
            {
                throw new Exception("Load capacity cannot be less than 0");
            }
            else
            {
                LoadCapacity = loadCapacity;
            }
            NumberOfAxles = numberOfAxles;
        }

        public override string DisplayInfo()
        {
            return $"Truck: {base.DisplayInfo()}\nLoad capacity: {LoadCapacity} tons\nNumber of axles: {NumberOfAxles}\n" +
                $"Max speed: {GetMaxSpeed()} km/h\nVehicle tax: ${CalculateTax()}\n";
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
