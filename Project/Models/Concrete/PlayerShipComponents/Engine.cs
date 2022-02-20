using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Engine : AEngine
    {
        public Engine(Engine original)
        {
            this.ID = original.ID;
            this.Speed = original.Speed;
            this.Plating = original.Plating;
            this.Name = original.Name;
            this.ActiveFuelConsumption = original.ActiveFuelConsumption;
            this.Worth = original.Worth;
            this.Weight = original.Weight;
        }

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