using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Hull : AHull
    {
        public Hull(Hull original)
        {
            this.ID = original.ID;
            this.Durability = original.Durability;
            this.Health = original.Health;
            this.Plating = original.Plating;
            this.Name = original.Name;
            this.Worth = original.Worth;
            this.Weight = original.Weight;
        }

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