using Diggity.Project.Models.Abstract;
using Diggity.Project.Models.Abstract.Grids;
using System.Numerics;

namespace Diggity.Project.Models.Concrete.Grids
{
    public class Grid : IGrid
    {
        public int ID { get; set; }
        public Vector2 InternalCoordinate { get; set; }
        public IGridBox[,] InternalGrid { get; set; }
        public ISize Size { get; set; }
    }
}