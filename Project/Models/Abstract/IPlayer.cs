using Diggity.Models.Abstract.PlayerShipComponents;
using Diggity.Models.Abstract.PlayerShipInventory;
using System.Collections.Generic;

namespace Diggity.Models.Abstract
{
    public interface IPlayer
    {
        public float XPosition { get; set; }
        public float YPosition { get; set; }

        public IDictionary<IBlock, int> BlocksMined { get; set; }

        public string Name { get; set; }
        public double Cash { get; set; }
        public IEngine Engine { get; set; }
        public IHull Hull { get; set; }
        public IDrill Drill { get; set; }
        public IInventory Inventory { get; set; }
        public float Weight { get; set; } // Based on Components and Inventory
    }
}