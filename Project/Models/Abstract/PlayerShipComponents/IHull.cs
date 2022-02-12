namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public interface IHull : IType
    {
        public float Durability { get; set; } // Health of the ship
        public IThermalPlating Plating { get; set; } // Heat dissipating plating
    }
}