using System.Numerics;

namespace Diggity.Project.Models.Abstract.Grids
{
    public interface IGrid
    {
        public int ID { get; set; }
        public Vector2 InternalCoordinate { get; set; }
        public IGridBox[,] InternalGrid { get; set; }
        public ISize Size { get; set; } // Size in pixels => Width: InternalGrid.GetLength(0) * BlockSize, Height: InternalGrid.GetLength(1) * BlockSize

        // TODO: Figure out what to do when grid size exceeds building window. Make Scrollable.
    }
}