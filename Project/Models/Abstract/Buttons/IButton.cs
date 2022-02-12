using System.Numerics;

namespace Diggity.Project.Models.Abstract.Buttons
{
    public interface IButton
    {
        public int ID { get; set; }
        public Vector2 InternalCoordinate { get; set; }
        public ISize Size { get; set; } // Size in pixels
    }
}