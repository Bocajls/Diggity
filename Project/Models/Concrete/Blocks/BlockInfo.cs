using Diggity.Project.Models.Abstract.Blocks;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

namespace Diggity.Project.Models.Concrete.Blocks
{
    public class BlockInfo : ABlockInfo
    {
        public BlockInfo()
        {

        }

        [JsonConstructor]
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
    }
}