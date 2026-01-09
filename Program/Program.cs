namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle[] vehicles =
            {
                new Car("Toyota", "Corolla", 2020, 25000, 4, "gasoline"),
                new Truck("Volvo", "FH16", 2021, 120000, 25, 4),
                new Motorcycle("Harley-Davidson", "Street Glide", 2022, 28000, 1746, true)
            };
            double totalVehicleTax = 0;
            int maxSpeed = int.MinValue;
            string maxVehicle = "";

            Console.WriteLine("=== Information about vehicles ===\n");
            foreach (var vehicle in vehicles)
            {
                totalVehicleTax += vehicle.CalculateTax();
                if (vehicle.GetMaxSpeed() > maxSpeed)
                {
                    maxSpeed = vehicle.GetMaxSpeed();
                    maxVehicle = vehicle.GetShortName();
                }
                Console.WriteLine(vehicle.DisplayInfo());
            }
            Console.WriteLine($"Total sum of vehicle tax: ${totalVehicleTax}");
            Console.WriteLine($"The fastest vehicle: {maxVehicle} ({maxSpeed} km/h)");
        }
    }
}