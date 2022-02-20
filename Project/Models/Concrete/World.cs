using Diggity.Project.Models.Abstract;
using Diggity.Project.Models.Abstract.Buildings;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
namespace Diggity.Project.Models.Concrete
{
    public class World : AWorld
    {
        public World(APlayer Player, List<ABuilding> Buildings, int BlocksWide, int BlocksHigh, Dictionary<Vector2, Vector2> WorldRender, Dictionary<Vector2, bool> WorldTrails)
        {
            this.Player = Player;
            this.Buildings = Buildings;
            this.BlocksWide = BlocksWide;
            this.BlocksHigh = BlocksHigh;
            this.WorldRender = WorldRender;
            this.WorldTrails = WorldTrails;
        }
    }
}