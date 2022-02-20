using Diggity.Project.Models.Abstract.Grids;
using Microsoft.Xna.Framework;

namespace Diggity.Project.Models.Concrete.Grids
{
    public class Grid : IGrid
    {
        public Grid(int ID, Vector2 InternalCoordinate, GridBox[,] InternalGrid)
        {
            this.ID = ID;
            this.InternalCoordinate = InternalCoordinate;
            this.InternalGrid = InternalGrid;
        }

        public int ID { get; set; }
        public Vector2 InternalCoordinate { get; set; }
        public IGridBox[,] InternalGrid { get; set; }
    }
}