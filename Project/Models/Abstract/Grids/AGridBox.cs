using Diggity.Project.Models.Abstract.Types;
using System.Collections.Generic;

namespace Diggity.Project.Models.Abstract.Grids
{
    public abstract class AGridBox
    {
        public int ID { get; set; }
        public List<AType> Item { get; set; }
    }
}