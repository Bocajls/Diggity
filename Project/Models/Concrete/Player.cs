using Diggity.Project.Models.Abstract;
using Diggity.Project.Models.Abstract.PlayerShipComponents;
using System.Numerics;

namespace Diggity.Project.Models.Concrete
{
    public class Player : IPlayer
    {
        public Player()
        {
            // Set manually
        }

        public Vector2 Coordinate { get; set; }
        public Vector2 Velocity { get; set; }
        public string Name { get; set; }
        public double Cash { get; set; }
        public IEngine Engine { get; set; }
        public IHull Hull { get; set; }
        public IDrill Drill { get; set; }
        public IInventory Inventory { get; set; }
        public IThruster Thruster { get; set; }
        public IFuelTank FuelTank { get; set; }
        public float Weight { get; set; }
    }
}