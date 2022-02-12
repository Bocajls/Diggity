﻿using Diggity.Project.Models.Concrete.Blocks;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete
{
    class WorldInteractionsRepository : Dictionary<(int X, int Y), MetaBlock>
    {
        public WorldInteractionsRepository()
        {
            // To contains previous X interactions user has had in the world.
            // Will contain a MetaBlock for X, Y coordinate with information.
        }
    }
}