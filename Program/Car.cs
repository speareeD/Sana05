namespace Program
{
    public class Car : Vehicle
    {
        protected int NumberOfDoors;
        protected string FuelType;

        public Car(string brand, string model, int year, double price, int numberOfDoors, string fuelType)
            : base(brand, model, year, price)
        {
            NumberOfDoors = numberOfDoors;
            FuelType = fuelType;
        }

        public override string DisplayInfo()
        {
            return $"Car: {base.DisplayInfo()}\nNumber of doors: {NumberOfDoors}\nFuel type: {FuelType}\n" +
                $"Max speed: {GetMaxSpeed()} km/h\nVehicle tax: ${CalculateTax()}\n";
        }

        public override double CalculateTax()
        {
            if (FuelType.ToLower() == "electro")
            {
                return Price * 0.0005;
            }
            return Price * 0.015;
        }

        public override int GetMaxSpeed()
        {
            return 180;
        }
    }
}
