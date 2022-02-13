using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Drill : IDrill
    {
        public Drill(short ID, float Hardness, IThermalPlating Plating, string Name)
        {
            this.ID = ID;
            this.Hardness = Hardness;
            this.Plating = Plating;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }

        public short ID { get; set; }
        public float Hardness { get; set; }
        public IThermalPlating Plating { get; set; }
        public string Name { get; set; }
        public float Worth { get; set; }
        public float Weight { get; set; }
    }
}