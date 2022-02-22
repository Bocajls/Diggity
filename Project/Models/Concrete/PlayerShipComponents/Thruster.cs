using Diggity.Project.Models.Abstract.PlayerShipComponents;
using Newtonsoft.Json;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Thruster : AThruster
    {
        public Thruster(Thruster original)
        {
            this.ID = original.ID;
            this.Speed = original.Speed;
            this.Acceleration = original.Acceleration;
            this.Power = original.Power;
            this.Plating = original.Plating;
            this.Name = original.Name;
            this.ActiveFuelConsumption = original.ActiveFuelConsumption;
            this.Weight = original.Weight;
            this.Worth = original.Worth;
        }

        [JsonConstructor]
        public Thruster(short ID, float Speed, float Acceleration, float Power, ThermalPlating Plating, string Name, float ActiveFuelConsumption, float Weight, float Worth)
        {
            this.ID = ID;
            this.Speed = Speed;
            this.Acceleration = Acceleration;
            this.Power = Power;
            this.Plating = Plating;
            this.Name = Name;
            this.ActiveFuelConsumption = ActiveFuelConsumption;
            this.Weight = Weight;
            this.Worth = Worth;
        }
    }
}