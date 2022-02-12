using Diggity.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class ThermalPlating : IThermalPlating
    {
        public ThermalPlating(short ID, float MaxThermals, float ThermalDissipation, string Name)
        {
            this.ID = ID;
            this.MaxThermals = MaxThermals;
            this.ThermalDissipation = ThermalDissipation;
            this.Name = Name;
        }

        public short ID { get; set; }
        public float MaxThermals { get; set; }
        public float ThermalDissipation { get; set; }
        public string Name { get; set; }
    }
}