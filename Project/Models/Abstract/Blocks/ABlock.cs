using System;

namespace Diggity.Project.Models.Abstract.Blocks
{
    public abstract class ABlock
    {
        public bool Destroyed { get; }
        public bool Ethereal { get; set; }
        public float Hardness { get; set; }
        public float MaximumHealth { get; set; }
        public float CurrentHealth { get; set; }
        public double Worth { get; set; }
        public ABlockInfo Info { get; set; }
    }
}