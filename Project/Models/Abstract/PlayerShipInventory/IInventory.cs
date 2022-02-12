using System.Collections.Generic;

namespace Diggity.Models.Abstract.PlayerShipInventory
{
    public interface IInventory
    {
        public IList<IType>[,] Items { get; set; }
    }
}