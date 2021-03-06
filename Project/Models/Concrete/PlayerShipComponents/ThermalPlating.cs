using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class ThermalPlating : IThermalPlating
    {
        public ThermalPlating(short ID, float Thermals, float MaxThermals, float ThermalDissipation, string Name, float Worth, float Weight)
        {
            this.ID = ID;
            this.Thermals = Thermals;
            this.MaxThermals = MaxThermals;
            this.ThermalDissipation = ThermalDissipation;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }

        public short ID { get; set; }
        public float Thermals { get; set; }
        public float MaxThermals { get; set; }
        public float ThermalDissipation { get; set; }
        public string Name { get; set; }
        public float Worth { get; set; }
        public float Weight { get; set; }
    }
}