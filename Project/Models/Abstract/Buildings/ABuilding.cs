using Diggity.Project.Models.Abstract;
using Diggity.Project.Models.Abstract.Buildings;
using Diggity.Project.Models.Abstract.Grids;
using System.Numerics;

namespace Diggity.Project.Models.Abstract.Buildings
{
    public abstract class ABuilding : IBuilding
    {
        // Abstract since every building with have special methods.

        public ABuilding(short ID, string Name, Vector2 GlobalCoordinate, IGrid StorageGrid, IGrid ActiveGrid, ISize Size)
        {
            this.ID = ID;
            this.Name = Name;
            this.GlobalCoordinate = GlobalCoordinate;
            this.StorageGrid = StorageGrid;
            this.ActiveGrid = ActiveGrid;
            this.Size = Size;
        }

        public short ID { get; set; }
        public string Name { get; set; }
        public Vector2 GlobalCoordinate { get; set; }
        public IGrid StorageGrid { get; set; } // Example in Smeltery the grid that contains ingots after having being processed.
        public IGrid ActiveGrid { get; set; } // Example in Smeltery the grid that contains ores that are currently being processed.
        public ISize Size { get; set; }
    }
}