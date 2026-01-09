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

    }
}
