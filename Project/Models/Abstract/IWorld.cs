using System.Collections.Generic;

namespace Diggity.Models.Abstract
{
    public interface IWorld
    {
        public IPlayer Player { get; set; }
        public IList<IShop> Shops { get; set; }
        public int BlocksWide { get; set; }
        public int BlocksHigh { get; set; }

        public byte[,] WorldBlocks { get; set; } // 0-255 (ID)
        public bool[,] WorldTrails { get; set; } // True of False (Destroyed)
    }
}