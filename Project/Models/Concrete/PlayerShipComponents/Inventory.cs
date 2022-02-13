using Diggity.Project.Models.Abstract.PlayerShipComponents;
using Diggity.Project.Models.Abstract.Grids;

namespace Diggity.Project.Models.Concrete.PlayerShipComponents
{
    public class Inventory : IInventory
    {
        public Inventory(short ID, IGrid Items, float SizeLimit, string Name, float Worth, float Weight)
        {
            this.ID = ID;
            this.Items = Items;
            this.SizeLimit = SizeLimit;
            this.Name = Name;
            this.Worth = Worth;
            this.Weight = Weight;
        }

        public short ID { get; set; }
        public IGrid Items { get; set; }
        public float SizeLimit { get; set; }
        public string Name { get; set; }
        public float Worth { get; set; }
        public float Weight { get; set; }
    }
}