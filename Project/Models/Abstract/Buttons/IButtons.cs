using System.Collections.Generic;

namespace Diggity.Project.Models.Abstract.Buttons
{
    public interface IButtons
    {
        public IList<IButton> Buttons { get; set; }
    }
}