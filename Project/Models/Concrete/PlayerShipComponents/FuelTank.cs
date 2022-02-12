using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    class FuelTank : IFuelTank
    {
        public float Capacity { get; set; }
        public string Name { get; set; }
        public short ID { get; set; }
    }
}