using Diggity.Project.Models.Abstract;

namespace Diggity.Project.Models.Concrete
{
    public class Size : ISize
    {
        public Size (float Width, float Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public float Width { get; set; }
        public float Height { get; set; }
    }
}