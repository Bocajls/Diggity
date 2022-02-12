using Diggity.Project.Models.Abstract.Buildings;
using Diggity.Project.Models.Abstract.Grids;
using System.Numerics;

namespace Diggity.Project.Models.Concrete.Buildings
{
    public abstract class MetaBuilding : IBuilding
    {
        public int ID { get; set; }
        public string StoreName { get; set; }
        public Vector2 GlobalCoordinate { get; set; }
        public string BuildingName { get; set; }
        public IGrid StorageGrid { get; set; } // Example in Smeltery the grid that contains ingots after having being processed.
        public IGrid ActiveGrid { get; set; } // Example in Smeltery the grid that contains ores that are currently being processed.
    }
}