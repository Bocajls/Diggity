using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Hull : AHull
    {
        public Hull(short ID, float Durability, float Health, ThermalPlating Plating, string Name, float Worth, float Weight)
        {
            this.ID = ID;
            this.Durability = Durability;
            this.Health = Health;
            this.Plating = Plating;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }
    }
}