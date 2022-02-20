using Diggity.Project.Models.Abstract.Types;

namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public abstract class AHull : AType
    {
        public float Health { get; set; }
        public float Durability { get; set; } // Maximum health of the ship
        public AThermalPlating Plating { get; set; } // Heat dissipating plating
    }
}