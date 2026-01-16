namespace Program
{
    public class Motorcycle : Vehicle
    {
        protected int EngineVolume;
        protected bool HasWindshield;

        public Motorcycle(string brand, string model, int year, double price, int engineVolume, bool hasWindshield)
            : base(brand, model, year, price)
        {
            if (engineVolume < 0)
            {
                throw new ArgumentException("Engine volume cannot be less than 0");
            }
            else
            {
                EngineVolume = engineVolume;
            }
            HasWindshield = hasWindshield;
        }

        public override string DisplayInfo()
        {
            return $"Motorcycle: {base.DisplayInfo()}\nEngine volume: {EngineVolume} cm3\nHas windshield: {HasWindshield}\n" +
                $"Max speed: {GetMaxSpeed()} km/h\nVehicle tax: ${CalculateTax()}\n";
        }

        public override double CalculateTax()
        {
            return Price * 0.008 + EngineVolume * 0.5;
        }

        public override int GetMaxSpeed()
        {
            return 200;
        }
    }
}
