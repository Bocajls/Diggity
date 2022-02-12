namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public interface IHull : IType
    {
        public float Health { get; set; }
        public float Durability { get; set; } // Maximum health of the ship
        public IThermalPlating Plating { get; set; } // Heat dissipating plating
    }
}