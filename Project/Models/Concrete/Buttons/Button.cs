using Diggity.Project.Models.Abstract;
using Diggity.Project.Models.Abstract.Buttons;
using System.Numerics;

namespace Diggity.Project.Models.Concrete.Buttons
{
    public class Button : IButton
    {
        public int ID { get; set; }
        public Vector2 InternalCoordinate { get; set; }
        public ISize Size { get; set; }
    }
}