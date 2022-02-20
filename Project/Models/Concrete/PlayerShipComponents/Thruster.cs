using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Thruster : AThruster
    {
        public Thruster(short ID, float Speed, float Power, ThermalPlating Plating, string Name, float ActiveFuelConsumption, float Weight, float Worth)
        {
            this.ID = ID;
            this.Speed = Speed;
            this.Power = Power;
            this.Plating = Plating;
            this.Name = Name;
            this.ActiveFuelConsumption = ActiveFuelConsumption;
            this.Weight = Weight;
            this.Worth = Worth;
        }
    }
}