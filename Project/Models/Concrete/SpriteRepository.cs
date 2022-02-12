using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Diggity.Project.Concrete.Utilities
{
    public class SpriteRepository : Dictionary<int, (string Name, Texture2D Texture)>
    {
        public SpriteRepository(ContentManager manager)
        {
            InitializeCollection(manager);
        }

        private void InitializeCollection(ContentManager manager)
        {
            Add(0, ("Air", manager.Load<Texture2D>("Graphics/Blocks/M_AirBlock")));
        }
    }
}
