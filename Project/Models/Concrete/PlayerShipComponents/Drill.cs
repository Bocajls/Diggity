using Diggity.Project.Models.Abstract.PlayerShipComponents;
using Newtonsoft.Json;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Drill : ADrill
    {
        public Drill(Drill original)
        {
            this.ID = original.ID;
            this.Hardness = original.Hardness;
            this.Damage = original.Damage;
            this.Plating = original.Plating;
            this.Name = original.Name;
            this.Worth = original.Worth;
            this.Weight = original.Weight;
        }

        [JsonConstructor]
        public Drill(short ID, float Hardness, float Damage, ThermalPlating Plating, string Name)
        {
            this.ID = ID;
            this.Hardness = Hardness;
            this.Damage = Damage;
            this.Plating = Plating;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }
    }
}