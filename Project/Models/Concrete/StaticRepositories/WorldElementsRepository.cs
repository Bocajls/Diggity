using Diggity.Models.Abstract;
using Diggity.Project.Models.Concrete.Blocks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Diggity.Project.Concrete.StaticRepositories
{
    public class WorldElementsRepository : Dictionary<int, (string Name, Texture2D Texture, IBlock block)>
    {
        public WorldElementsRepository(ContentManager manager)
        {
            InitializeCollection(manager);
        }

        private void InitializeCollection(ContentManager manager)
        {
            // Limitation of 0-255 world block types
            Add(0, ("Air", manager.Load<Texture2D>("Graphics/Blocks/M_AirBlock"), new MetaBlock(Ethereal:true)));
        }
    }
}