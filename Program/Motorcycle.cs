namespace Program
{
    public class Motorcycle : Vehicle
    {
        protected int EngineVolume;
        protected bool HasWindshield;

        public Motorcycle(string brand, string model, int year, double price, int engineVolume, bool hasWindshield)
            : base(brand, model, year, price)
        {
            EngineVolume = engineVolume;
            HasWindshield = hasWindshield;
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, Engine volume: {EngineVolume} cm3, Has windshield: {HasWindshield}";
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
