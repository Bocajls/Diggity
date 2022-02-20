using Diggity.Project.Models.Abstract.Buildings;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Diggity.Project.Models.Abstract
{
    public abstract class AWorld
    {
        public APlayer Player { get; set; }
        public List<ABuilding> Buildings { get; set; }
        public int BlocksWide { get; set; }
        public int BlocksHigh { get; set; }

        public Dictionary<Vector2, Vector2> WorldRender { get; set; }
        public Dictionary<Vector2, bool> WorldTrails { get; set; }
    }
}