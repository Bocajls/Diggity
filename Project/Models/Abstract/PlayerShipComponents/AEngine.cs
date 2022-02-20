using Diggity.Project.Models.Abstract.Types;

namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public abstract class AEngine : AType
    {
        public float ActiveFuelConsumption { get; set; } // When Mining
        public float Speed { get; set; } // Maximum drill spinning speed
        public AThermalPlating Plating { get; set; } // Heat dissipating plating. Maybe only thermalplating on hull (?)
    }
}
