using Diggity.Project.Models.Abstract.PlayerShipComponents;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class ThermalPlating : AThermalPlating
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
    }
}