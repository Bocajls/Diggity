namespace Diggity.Project.Models.Abstract
{
    public interface IConsumeable : IType
    {
        public double Worth { get; set; }

        // TODO: Function of consumable: tnt, teleporter, hull repair, speed-up etc.
    }
}