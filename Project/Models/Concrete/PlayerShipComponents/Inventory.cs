using Diggity.Models.Abstract;
using Diggity.Models.Abstract.PlayerShipComponents;
using Diggity.Project.Models.Abstract.Grids;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    class Inventory : IInventory
    {
        public Inventory()
        {
            this.ID = ID;
            this.Items = Items;
            this.SizeLimit = SizeLimit;
            this.Name = Name;
        }

        public short ID { get; set; }
        public IGrid Items { get; set; }
        public float SizeLimit { get; set; }
        public string Name { get; set; }
    }
}