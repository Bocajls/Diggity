using Diggidy.Models.Abstract;

namespace Diggity.Project.Models.Concrete.Blocks
{
    public class MetaBlock : IBlock
    {
        public MetaBlock(float Hardness = 0, float Health = 0, double Worth = 0, short ID = 0)
        {
            this.Hardness = Hardness;
            this.Health = Health;
            this.Worth = Worth;
        }

        public float Hardness { get; set; }
        public float Health { get; set; }
        public double Worth { get; set; }
    }
}