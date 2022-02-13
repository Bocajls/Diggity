using Diggity.Project.Models.Abstract;
using Diggity.Project.Models.Abstract.Buildings;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete
{
    public class World : IWorld
    {
        public World(IPlayer Player, IList<IBuilding> Buildings, int BlocksWide, int BlocksHigh, byte[,] WorldBlocks, bool[,] WorldTrails)
        {
            this.Player = Player;
            this.Buildings = Buildings;
            this.BlocksWide = BlocksWide;
            this.BlocksHigh = BlocksHigh;
            this.WorldBlocks = WorldBlocks;
            this.WorldTrails = WorldTrails;
        }

        public IPlayer Player { get; set; }
        public IList<IBuilding> Buildings { get; set; }
        public int BlocksWide { get; set; }
        public int BlocksHigh { get; set; }
        public byte[,] WorldBlocks { get; set; }
        public bool[,] WorldTrails { get; set; }
    }
}