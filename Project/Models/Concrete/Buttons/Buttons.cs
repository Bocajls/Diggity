using Diggity.Project.Models.Abstract.Buttons;
using System.Collections.Generic;

namespace Diggity.Project.Models.Concrete.Buttons
{
    public class Buttons
    {
        public IList<IButton> ButtonCollection { get; set; }
    }
}