using Diggity.Project.Models.Abstract.Grids;
using Diggity.Project.Models.Abstract.Types;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete.Grids
{
    public class GridBox : AGridBox
    {
        public GridBox(int ID, List<AType> Item)
        {
            this.ID = ID;
            this.Item = Item;
        }
    }
}