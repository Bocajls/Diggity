using Diggity.Project.Models.Abstract;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete.StaticRepositories
{
    public class GameItemsRepository : Dictionary<int, (string Name, Texture2D Texture, IType type)>
    {
        public GameItemsRepository(ContentManager manager)
        {
            InitializeCollection(manager);
        }

        private void InitializeCollection(ContentManager manager)
        {
            // Limitation of 0-255 world block types
            // Add(0, ("ScrapThruster", manager.Load<Texture2D>("Graphics/Blocks/M_ScrapThruster"), new Thruster(ID: 1, Speed: 2, Power: 50, Plating: null, Name: "ScrapThruster")));
        }
    }
}