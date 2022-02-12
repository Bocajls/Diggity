using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    class FuelTank : IFuelTank
    {
        public FuelTank(short ID, float Capacity, string Name)
        {
            this.ID = ID;
            this.Capacity = Capacity;
            this.Name = Name;
        }

        public short ID { get; set; }
        public float Capacity { get; set; }
        public string Name { get; set; }
    }
}