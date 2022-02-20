using Diggity.Project.Models.Abstract;

namespace Diggity.Project.Models.Concrete
{
    public class Size : ASize
    {
        public Size (float Width, float Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
    }
}