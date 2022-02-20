using Diggity.Project.Models.Abstract.Grids;
using Microsoft.Xna.Framework;

namespace Diggity.Project.Models.Abstract.Buildings
{
    public interface IBuilding
    {
        public short ID { get; set; }
        public Vector2 GlobalCoordinate { get; set; }
        public string Name { get; set; }
        public IGrid StorageGrid { get; set; }
        public IGrid ActiveGrid { get; set; }
        public ISize Size { get; set; } // Size in pixels
    }
}