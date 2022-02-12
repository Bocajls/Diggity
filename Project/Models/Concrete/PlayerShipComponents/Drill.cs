using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    class Drill : IDrill
    {
        public Drill(short ID, float Hardness, IThermalPlating Plating, string Name)
        {
            this.ID = ID;
            this.Hardness = Hardness;
            this.Plating = Plating;
            this.Name = Name;
        }

        public short ID { get; set; }
        public float Hardness { get; set; }
        public IThermalPlating Plating { get; set; }
        public string Name { get; set; }
    }
}