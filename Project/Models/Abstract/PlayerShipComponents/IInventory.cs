using Diggity.Project.Models.Abstract.Grids;

namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public interface IInventory : IType
    {
        public float SizeLimit { get; set; }
        public IGrid Items { get; set; }
    }
}