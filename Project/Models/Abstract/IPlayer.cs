using Diggity.Models.Abstract.PlayerShipComponents;
using System.Numerics;

namespace Diggity.Models.Abstract
{
    public interface IPlayer
    {
        public Vector2 Coordinate { get; set; }
        public string Name { get; set; }
        public double Cash { get; set; }
        public IEngine Engine { get; set; }
        public IHull Hull { get; set; }
        public IDrill Drill { get; set; }
        public IInventory Inventory { get; set; }
        public IThruster Thruster { get; set; }
        public float Weight { get; set; }
    }
}