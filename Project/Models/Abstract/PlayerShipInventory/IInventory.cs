using System.Collections.Generic;

namespace Diggidy.Models.Abstract.PlayerShipInventory
{
    public interface IInventory
    {
        public IList<IType>[,] Items { get; set; }
    }
}