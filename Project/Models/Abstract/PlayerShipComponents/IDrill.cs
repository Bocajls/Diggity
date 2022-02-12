namespace Diggity.Models.Abstract.PlayerShipComponents
{
    public interface IDrill : IType
    {
        public float Hardness { get; set; } // How hard a mineral can this drill mine
        public IThermalPlating Plating { get; set; } // Heat dissipating plating
    }
}