namespace Diggity.Models.Abstract.PlayerShipComponents
{
    public interface IEngine : IType
    {
        public float Speed { get; set; } // Maximum drill spinning speed
        public IThermalPlating Plating { get; set; } // Heat dissipating plating
    }
}
