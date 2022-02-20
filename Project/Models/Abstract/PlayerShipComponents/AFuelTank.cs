using Diggity.Project.Models.Abstract.Types;

namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public abstract class AFuelTank : AType
    {
        public float Fuel { get; set; }
        public float Capacity { get; set; }
    }
}