using Diggity.Project.Models.Abstract.Grids;
using Microsoft.Xna.Framework;

namespace Diggity.Project.Models.Abstract.Buildings
{
    public interface IBuilding
    {
        public short ID { get; set; }
        public Vector2 GlobalCoordinate { get; set; }
        public string Name { get; set; }
        public AGrid StorageGrid { get; set; }
        public AGrid ActiveGrid { get; set; }
        public ASize Size { get; set; } // Size in pixels
    }
}