using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Thruster : IThruster
    {
        public Thruster(short ID, float Speed, float Power, IThermalPlating Plating, string Name, float ActiveFuelConsumption, float Weight, float Worth)
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

        public short ID { get; set; }
        public float Speed { get; set; }
        public float Power { get; set; }
        public IThermalPlating Plating { get; set; }
        public string Name { get; set; }
        public float ActiveFuelConsumption { get; set; }
        public float Worth { get; set; }
        public float Weight { get; set; }
    }
}