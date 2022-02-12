using Diggity.Models.Abstract;
using Diggity.Models.Abstract.PlayerShipInventory;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete.PlayerShipInventory
{
    class Inventory : IInventory
    {
        public IList<IType>[,] Items { get; set; }
    }
}
