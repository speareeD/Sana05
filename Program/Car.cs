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


    }
}
