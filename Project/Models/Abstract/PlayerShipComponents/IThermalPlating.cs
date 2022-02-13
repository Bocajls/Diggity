using Diggity.Project.Models.Abstract.Types;

namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public interface IThermalPlating : IType
    {
        public float Thermals { get; set; }
        public float MaxThermals { get; set; } // Maximum temperature endurance
        public float ThermalDissipation { get; set; }
    }
}