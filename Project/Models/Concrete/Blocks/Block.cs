using Diggity.Project.Models.Abstract.Blocks;
using System;

namespace Diggity.Project.Models.Concrete.Blocks
{
    public class Block : IBlock
    {
        public event EventHandler OnBlockDestroyed;

        public Block()
        {

        }

        public Block(bool Ethereal = false, float Hardness = 0, float Health = 0, double Worth = 0, IBlockInfo Info = null)
        {
            this.Ethereal = Ethereal;
            this.Hardness = Hardness;
            this.MaximumHealth = Health;
            this.CurrentHealth = Health;
            this.Worth = Worth;
            this.Info = Info;
        }

        public bool Destroyed => !Ethereal && CurrentHealth <= 0; 
        public bool Ethereal { get; set; }
        public float Hardness { get; set; }
        public float MaximumHealth { get; set; }
        public float CurrentHealth { get; set; }
        public double Worth { get; set; }
        public IBlockInfo Info { get; set; }

        public void TakeDamage(float damage)
        {
            if (this.CurrentHealth == 0 || this.Ethereal)
            {
                return;
            }

            this.CurrentHealth -= CalculatePenetrationDamage(damage);

            if (CurrentHealth <= 0)
            {
                this.CurrentHealth = 0;

                OnBlockDestroyed?.Invoke(this, EventArgs.Empty);
            }
        }

        public float CalculatePenetrationDamage(float drillDamage)
        {
            return (drillDamage - Hardness) <= 0 ? 0 : (drillDamage - Hardness);
        }

        // Etheral blocks do not block player ship from moving on over them.
        public bool BlockIsEthereal() => Ethereal;
    }
}