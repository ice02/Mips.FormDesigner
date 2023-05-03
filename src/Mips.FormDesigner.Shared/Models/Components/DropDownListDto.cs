using System;
using System.Collections.Generic;
using System.Text;

namespace Mips.FormDesigner.Models.Components
{
    public class DropDownListDto : ComponentDto
    {
        public DropDownListDto() : base(ComponentType.DropDownList) { }

        public Dictionary<int,string> Items { get; set; }
        public int DefaultValue { get; set; }
    }
}
