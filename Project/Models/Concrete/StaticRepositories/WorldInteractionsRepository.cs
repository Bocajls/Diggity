using Diggity.Project.Models.Concrete.Blocks;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete.StaticRepositories
{
    public class WorldInteractionsRepository : Dictionary<Vector2, Block>
    {
        public WorldInteractionsRepository()
        {
            // To contains previous X interactions user has had in the world.
            // Will contain a MetaBlock for X, Y coordinate with information.
        }
    }
}