using Diggity.Project.Models.Abstract.Types;
using System.Collections.Generic;

namespace Diggity.Project.Models.Abstract.Grids
{
    public interface IGridBox
    {
        public int ID { get; set; }
        public IList<IType> Item { get; set; }
    }
}