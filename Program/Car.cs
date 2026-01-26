using System.Net.Http.Headers;

namespace Program
{
    public class Car : Vehicle
    {
        protected int NumberOfDoors;
        protected string FuelType;

        public Car(string brand, string model, int year, double price, int numberOfDoors, string fuelType)
            : base(brand, model, year, price)
        {
            if (numberOfDoors < 2)
                throw new Exception("The number of doors cannot be less than 2");
            if (fuelType.ToLower() != "electro" && fuelType.ToLower() != "gasoline" && fuelType.ToLower() != "diesel")
                throw new Exception("Fuel type can only be electro, gasoline or diesel");

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
                return Price * 0.0005;
            else
                return Price * 0.015;
        }

        public override int GetMaxSpeed()
        {
            return 180;
        }
    }
}
