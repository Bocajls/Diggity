using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Drill : ADrill
    {
        public Drill(short ID, float Hardness, ThermalPlating Plating, string Name)
        {
            this.ID = ID;
            this.Hardness = Hardness;
            this.Plating = Plating;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }
    }
}