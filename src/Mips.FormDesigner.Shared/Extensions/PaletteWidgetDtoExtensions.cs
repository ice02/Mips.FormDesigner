using Mips.FormDesigner.Models;
using Mips.FormDesigner.Models.Components;

namespace Mips.FormDesigner.Extensions
{
    public static class PaletteWidgetDtoExtensions
    {
        public static ComponentDto CreateComponent(this PaletteWidgetDto paletteWidget)
        {
            ComponentDto componentData = null;

            switch (paletteWidget.ComponentType)
            {
                case ComponentType.Checkbox:
                    componentData = new CheckboxDto();
                    break;
                case ComponentType.DropDownList:
                    componentData = new DropDownListDto();
                    break;
                default:
                    componentData = new ComponentDto(paletteWidget.ComponentType);
                    break;
            }

            return componentData;
        }
    }
}
