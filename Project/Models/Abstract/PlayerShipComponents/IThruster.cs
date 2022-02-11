namespace Diggidy.Models.Abstract.PlayerShipComponents
{
    interface IThruster : IType
    {
        public float Speed { get; set; } // Top speed of air-movement for ship
        public float Power { get; set; } // How much can the thrusters air-lift
        public IThermalPlating Plating { get; set; } // Head dissipating plating
    }
}