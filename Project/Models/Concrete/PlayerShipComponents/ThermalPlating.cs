using Diggity.Project.Models.Abstract.PlayerShipComponents;
using Newtonsoft.Json;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class ThermalPlating : AThermalPlating
    {
        public ThermalPlating(ThermalPlating original)
        {
            this.ID = original.ID;
            this.Thermals = original.Thermals;
            this.MaxThermals = original.MaxThermals;
            this.ThermalDissipation = original.ThermalDissipation;
            this.Name = original.Name;
            this.Worth = original.Worth;
            this.Weight = original.Weight;
        }

        [JsonConstructor]
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