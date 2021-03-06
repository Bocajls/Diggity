using Diggity.Project.Models.Abstract.Types;

namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public interface IEngine : IType
    {
        public float ActiveFuelConsumption { get; set; } // When Mining
        public float Speed { get; set; } // Maximum drill spinning speed
        public IThermalPlating Plating { get; set; } // Heat dissipating plating. Maybe only thermalplating on hull (?)
    }
}
