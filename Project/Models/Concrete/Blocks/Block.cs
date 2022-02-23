using Diggity.Project.Models.Abstract.Blocks;
using Newtonsoft.Json;
using System;

namespace Diggity.Project.Models.Concrete.Blocks
{
    public class Block : ABlock
    {
        public event EventHandler OnBlockDestroyed;

        public Block()
        {

        }

        public Block(Block original)
        {
            this.ID = original.ID;
            this.Ethereal = original.Ethereal;
            this.Hardness = original.Hardness;
            this.MaximumHealth = original.MaximumHealth;
            this.CurrentHealth = original.CurrentHealth;
            this.Worth = original.Worth;
            this.Info = original.Info;
        }

        [JsonConstructor]
        public Block(short ID, bool Ethereal = false, float Hardness = 0, float Health = 0, float Worth = 0, BlockInfo Info = null)
        {
            this.ID = ID;
            this.Ethereal = Ethereal;
            this.Hardness = Hardness;
            this.MaximumHealth = Health;
            this.CurrentHealth = Health;
            this.Worth = Worth;
            this.Info = Info;
        }

        public void TakeDamage(float damage)
        {
            if (this.CurrentHealth == 0 || this.Ethereal)
            {
                return;
            }

            this.CurrentHealth -= damage;//CalculatePenetrationDamage(damage);

            if (CurrentHealth <= 0)
            {
                this.CurrentHealth = 0;

                OnBlockDestroyed?.Invoke(this, EventArgs.Empty);
            }
        }

        /*
        public float CalculatePenetrationDamage(float drillDamage)
        {
            return (drillDamage - Hardness) <= 0 ? 0 : (drillDamage - Hardness);
        }
        */

        // Etheral blocks do not block player ship from moving on over them.
        public bool BlockIsEthereal() => Ethereal;
    }
}