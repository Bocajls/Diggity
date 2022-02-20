using Microsoft.Xna.Framework;

namespace Diggity.Project.Models.Abstract.Blocks
{
    public interface IBlockInfo
    {
        public int MinimumDepth { get; set; }
        public int MaximumDepth { get; set; }
        public Vector2 OccurrenceSpan { get; set; }
    }
}
