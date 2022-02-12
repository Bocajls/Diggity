namespace Diggidy.Models.Abstract
{
    public interface IBlock
    {
        public float Hardness { get; set; }
        public float Health { get; set; }
        public double Worth { get; set; }
    }
}