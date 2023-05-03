using Mips.FormDesigner.Models;
using Microsoft.AspNetCore.Components;

namespace Mips.FormDesigner.Designer.Whiteboard.Components
{
    public partial class WidgetComponentBase : ComponentBase
    {
        [Parameter]
        public ComponentDto Component { get; set; }

        public WidgetComponentBase()
        {

        }
    }
}
