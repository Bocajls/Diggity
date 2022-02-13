using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class FuelTank : IFuelTank
    {
        public FuelTank(short ID, float Capacity, float Fuel, string Name, float Worth, float Weight)
        {
            this.ID = ID;
            this.Capacity = Capacity;
            this.Fuel = Fuel;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }

        public short ID { get; set; }
        public float Capacity { get; set; }
        public float Fuel { get; set; }
        public string Name { get; set; }
        public float Worth { get; set; }
        public float Weight { get; set; }
    }
}