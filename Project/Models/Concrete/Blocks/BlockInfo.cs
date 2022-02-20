using Diggity.Project.Models.Abstract.Blocks;
using Microsoft.Xna.Framework;
using System;

namespace Diggity.Project.Models.Concrete.Blocks
{
    public class BlockInfo : IBlockInfo
    {
        public BlockInfo()
        {

        }

        public BlockInfo(int MinimumDepth = -1, int MaximumDepth = -1, Vector2 OccurrenceSpan = new Vector2())
        {
            this.MinimumDepth = MinimumDepth;
            this.MaximumDepth = MaximumDepth;

            if(OccurrenceSpan is { })
            {
                this.OccurrenceSpan = OccurrenceSpan;
            }
            else
            {
                this.OccurrenceSpan = new Vector2(0, 0);
            }
        }

        public int MinimumDepth { get; set; }
        public int MaximumDepth { get; set; }
        public Vector2 OccurrenceSpan { get; set; }
    }
}
