namespace Diggity.Models.Abstract.PlayerShipComponents
{
    public interface IThruster : IType
    {
        public float ActiveFuelConsumption { get; set; } // When moving around
        public float Speed { get; set; } // Top speed of air-movement for ship
        public float Power { get; set; } // How much can the thrusters air-lift
        public IThermalPlating Plating { get; set; } // Heat dissipating plating
    }
}