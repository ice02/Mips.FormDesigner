using Mips.FormDesigner.Core;
using Mips.FormDesigner.Models.Components;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Mips.FormDesigner.Models
{
    [JsonDerivedType(typeof(CheckboxDto), typeDiscriminator: "Checkbox")]
    [JsonDerivedType(typeof(DropDownListDto), typeDiscriminator: "DropDownList")]
    [JsonDerivedType(typeof(SingleLineDto), typeDiscriminator: "SingleLine")]
    public class ComponentDto : ComponentBaseDto
    {
        public ComponentDto()
        {
            //Type = ComponentType.SingleLine;
            //Label = $"{Type.GetName()}-{Guid.NewGuid()}";
            //IsMandatory = false ;
        }

        public ComponentDto(ComponentType type)
        {
            InitializeComponent(type);
        }

        public ComponentDto(Guid id, ComponentType type) : base(id)
        {
            InitializeComponent(type);
        }

        internal void InitializeComponent(ComponentType type)
        {
            Type = type;
            Label = $"{Type.GetName()}-{Guid.NewGuid()}";
            IsMandatory = false ;

            if (Type == ComponentType.Tabs)
            {
                ChildContainers = new List<ContainerDto>()
                {
                    new ContainerDto(ContainerType.Tab)
                    {
                        Label = "Tab 1"
                    }
                };
            }
        }

        public ComponentDto Parent { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        public ComponentType Type { get; set; }

        public string Label { get; set; }

        public bool IsMandatory { get; set; }

        //// Components have common Metadata in base type and specifics properties in dedicated types

        //// component has row and column info if it is a widget
        //public int? Row { get; set; }
        //public int? Column { get; set; }

        //// component has order and title info if it is a tab widget
        //public int? Order { get; set; }
        //public string TabTitle { get; set; }

        public List<ContainerDto> ChildContainers { get; set; }

        private int width = ComponentUtils.MaxColumnWidth;
        public int Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    width = 0;
                }
                else if (value > 12)
                {
                    width = 12;
                }
                else
                {
                    width = value;
                }
            }
        }
    }
}
