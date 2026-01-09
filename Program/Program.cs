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

        }
    }
}