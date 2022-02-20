using Diggity.Project.Models.Abstract.Buttons;

namespace Diggity.Project.Models.Concrete.Buttons
{
    public class Button : AButton
    {
        public Button()
        {
            this.ID = ID;
            this.InternalCoordinate = InternalCoordinate;
            this.Size = Size;
        }
    }
}