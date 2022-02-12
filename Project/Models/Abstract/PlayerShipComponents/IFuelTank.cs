namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public interface IFuelTank : IType
    {
        public float Fuel { get; set; }
        public float Capacity { get; set; }
    }
}