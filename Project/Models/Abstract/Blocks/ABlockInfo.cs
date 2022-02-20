using Microsoft.Xna.Framework;
using System;

namespace Diggity.Project.Models.Abstract.Blocks
{
    public abstract class ABlockInfo
    {
        public int MinimumDepth { get; set; }
        public int MaximumDepth { get; set; }
        public Vector2 OccurrenceSpan { get; set; }
    }
}
