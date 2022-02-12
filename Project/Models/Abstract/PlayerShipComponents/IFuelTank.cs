using Diggity.Models.Abstract;

namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    interface IFuelTank : IType
    {
        public float Capacity { get; set; }
    }
}