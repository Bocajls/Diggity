namespace Diggity.Project.Models.Abstract.Blocks
{
    public interface IBlock
    {
        public bool Destroyed { get; }
        public bool Ethereal { get; set; }
        public float Hardness { get; set; }
        public float MaximumHealth { get; set; }
        public float CurrentHealth { get; set; }
        public double Worth { get; set; }
        public IBlockInfo Info { get; set; }
    }
}