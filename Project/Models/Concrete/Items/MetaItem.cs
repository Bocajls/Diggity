using Diggity.Project.Models.Abstract;

namespace Diggity.Project.Models.Items.Concrete
{
    public abstract class MetaItem : IType
    {
        public short ID { get; set; }
        public string Name { get; set; }
        public float Worth { get; set; }

        /* Move below to ICraftingRecipe and impl. model for CraftingRecipe */

        //public bool Craftable { get; set; }

        //public IType[,] Recipe { get; set; }
    }
}