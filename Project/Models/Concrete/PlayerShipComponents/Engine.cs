using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Engine : AEngine
    {
        public Engine(short ID, float Speed, ThermalPlating Plating, string Name, float ActiveFuelConsumption, float Worth, float Weight)
        {
            this.ID = ID;
            this.Speed = Speed;
            this.Plating = Plating;
            this.Name = Name;
            this.ActiveFuelConsumption = ActiveFuelConsumption;
            this.Worth = Worth;
            this.Weight = Weight;
        }
    }
}