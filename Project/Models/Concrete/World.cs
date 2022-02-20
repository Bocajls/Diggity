using Diggity.Project.Models.Abstract;
using Diggity.Project.Models.Abstract.Buildings;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
namespace Diggity.Project.Models.Concrete
{
    public class World : IWorld
    {
        public World(IPlayer Player, IList<IBuilding> Buildings, int BlocksWide, int BlocksHigh, Dictionary<Vector2, Vector2> WorldRender, Dictionary<Vector2, bool> WorldTrails)
        {
            this.Player = Player;
            this.Buildings = Buildings;
            this.BlocksWide = BlocksWide;
            this.BlocksHigh = BlocksHigh;
            this.WorldRender = WorldRender;
            this.WorldTrails = WorldTrails;
        }

        public IPlayer Player { get; set; }
        public IList<IBuilding> Buildings { get; set; }
        public int BlocksWide { get; set; }
        public int BlocksHigh { get; set; }
        public Dictionary<Vector2, Vector2> WorldRender { get; set;} // byte[,] WorldBlocks { get; set; }
        public Dictionary<Vector2, bool> WorldTrails { get; set; }
    }
}