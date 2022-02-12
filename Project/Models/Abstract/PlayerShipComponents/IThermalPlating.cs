namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public interface IThermalPlating : IType
    {
        public float MaxThermals { get; set; } // Maximum temperature endurance
        public float ThermalDissipation { get; set; }
    }
}