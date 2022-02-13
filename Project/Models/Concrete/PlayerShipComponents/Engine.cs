using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Engine : IEngine
    {
        public Engine(short ID, float Speed, IThermalPlating Plating, string Name, float ActiveFuelConsumption, float Worth, float Weight)
        {
            this.ID = ID;
            this.Speed = Speed;
            this.Plating = Plating;
            this.Name = Name;
            this.ActiveFuelConsumption = ActiveFuelConsumption;
            this.Worth = Worth;
            this.Weight = Weight;
        }

        public short ID { get; set; }
        public float Speed { get; set; }
        public IThermalPlating Plating { get; set; }
        public string Name { get; set; }
        public float ActiveFuelConsumption { get; set; }
        public float Worth { get; set; }
        public float Weight { get; set; }
    }
}