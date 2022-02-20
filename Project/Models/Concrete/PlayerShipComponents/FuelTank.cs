using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class FuelTank : AFuelTank
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
    }
}