using Diggity.Project.Models.Abstract.Grids;
using System.Numerics;

namespace Diggity.Project.Models.Abstract.Buildings
{
    public interface IBuilding
    {
        public int ID { get; set; }
        public Vector2 GlobalCoordinate { get; set; }
        public string BuildingName { get; set; }
        public IGrid StorageGrid { get; set; }
        public IGrid ActiveGrid { get; set; }
        public ISize Size { get; set; } // Size in pixels
    }
}