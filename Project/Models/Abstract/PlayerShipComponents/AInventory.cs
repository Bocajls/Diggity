using Diggity.Project.Models.Abstract.Grids;
using Diggity.Project.Models.Abstract.Types;

namespace Diggity.Project.Models.Abstract.PlayerShipComponents
{
    public abstract class AInventory : AType
    {
        public float SizeLimit { get; set; }
        public AGrid Items { get; set; }
    }
}