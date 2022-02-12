using Diggity.Project.Models.Concrete.Blocks;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete.StaticRepositories
{
    public class WorldInteractionsRepository : Dictionary<(int X, int Y), Block>
    {
        public WorldInteractionsRepository()
        {
            // To contains previous X interactions user has had in the world.
            // Will contain a MetaBlock for X, Y coordinate with information.
        }
    }
}