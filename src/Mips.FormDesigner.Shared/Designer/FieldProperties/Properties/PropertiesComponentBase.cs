﻿using Mips.FormDesigner.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Mips.FormDesigner.Designer.FieldProperties.Properties
{
    public class PropertiesComponentBase : ComponentBase
    {
        public PropertiesComponentBase()
        {
        }

        [CascadingParameter(Name = "FormDesigner")]
        public FormDesigner FormDesigner { get; set; }

        [Parameter]
        public ComponentDto ComponentData { get; set; }

        public async Task OnLabelChangedAsync(ChangeEventArgs e)
        {
            ComponentData.Label = e.Value.ToString();

            await FormDesigner.StateHasChangedAsync();
        }

        public async Task OnWidthChangedAsync(ChangeEventArgs e)
        {
            ComponentData.Width = Convert.ToInt32(e.Value);

            await FormDesigner.StateHasChangedAsync();
        }

        public async Task OnIsMandatoryChangedAsync(ChangeEventArgs e)
        {
            ComponentData.IsMandatory = Convert.ToBoolean(e.Value);

            await FormDesigner.StateHasChangedAsync();
        }
    }
}
