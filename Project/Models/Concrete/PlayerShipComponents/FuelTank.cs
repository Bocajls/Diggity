using Diggity.Project.Models.Abstract.PlayerShipComponents;
using Newtonsoft.Json;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class FuelTank : AFuelTank
    {
        public FuelTank(FuelTank original)
        {
            this.ID = original.ID;
            this.Capacity = original.Capacity;
            this.Fuel = original.Fuel;
            this.Name = original.Name;
            this.Worth = original.Worth;
            this.Weight = original.Weight;
        }

        [JsonConstructor]
        public FuelTank(short ID, float Capacity, float Fuel, string Name, float Worth, float Weight)
        {
            this.ID = ID;
            this.Capacity = Capacity;
            this.Fuel = Fuel;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }
    }
}