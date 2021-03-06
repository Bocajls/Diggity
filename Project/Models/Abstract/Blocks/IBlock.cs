namespace Diggity.Project.Models.Abstract.Blocks
{
    public interface IBlock
    {
        public float Hardness { get; set; }
        public float MaximumHealth { get; set; }
        public float CurrentHealth { get; set; }
        public double Worth { get; set; }
    }
}