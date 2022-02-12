using Diggity.Models.Abstract;

namespace Diggity.Project.Models.Abstract.Grids
{
    public interface IGridBox
    {
        public int ID { get; set; }
        public IType Item { get; set; }
    }
}