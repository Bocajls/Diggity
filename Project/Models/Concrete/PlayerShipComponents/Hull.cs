using Diggidy.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Hull : IHull
    {
        public Hull(short ID, float Durability, IThermalPlating Plating, string Name)
        {
            this.ID = ID;
            this.Durability = Durability;
            this.Plating = Plating;
            this.Name = Name;
        }

        public short ID { get; set; }
        public float Durability { get; set; }
        public IThermalPlating Plating { get; set; }
        public string Name { get; set; }
    }
}