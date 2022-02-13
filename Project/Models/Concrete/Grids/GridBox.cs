using Diggity.Project.Models.Abstract.Grids;
using Diggity.Project.Models.Abstract.Types;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete.Grids
{
    public class GridBox : IGridBox
    {
        public int ID { get; set; }
        public IList<IType> Item { get; set; }
    }
}