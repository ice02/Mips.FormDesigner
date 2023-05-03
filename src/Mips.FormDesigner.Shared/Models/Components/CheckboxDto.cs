using System;
using System.Collections.Generic;
using System.Text;

namespace Mips.FormDesigner.Models.Components
{
    public class CheckboxDto : ComponentDto
    {
        public CheckboxDto() : base(ComponentType.Checkbox) { }

        public bool IsChecked { get; set; }
    }
}
