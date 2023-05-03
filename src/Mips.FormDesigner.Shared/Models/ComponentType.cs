using System;
using System.Runtime.Serialization;

namespace Mips.FormDesigner.Models
{
    public enum ComponentType
    {
        [EnumMember(Value = @"SingleLine")]
        SingleLine = 0,
        [EnumMember(Value = @"MultiLine")]
        MultiLine = 1,
        [EnumMember(Value = @"Link")]
        Link = 2,
        [EnumMember(Value = @"Email")]
        Email = 3,
        [EnumMember(Value = @"Checkbox")]
        Checkbox = 4,
        Number = 5,
        File = 6,
        DateTime = 7,
        Image = 8,
        Choice = 9,
        Tabs = 10,
        DropDownList = 11
    }

    public static class ComponentTypeExtensions
    {
        public static string GetName(this ComponentType componentType)
        {
            string result = componentType switch
            {
                ComponentType.SingleLine => "Single Line",
                ComponentType.MultiLine => "Multi Line",
                ComponentType.Link => "Link",
                ComponentType.Email => "Email",
                ComponentType.Checkbox => "Check",
                ComponentType.Number => "Number",
                ComponentType.File => "File",
                ComponentType.DateTime => "DateTime",
                ComponentType.Image => "Image",
                ComponentType.Choice => "Choice",
                ComponentType.Tabs => "Tabs",
                ComponentType.DropDownList => "DropDownList",
                _ => throw new NotImplementedException(@$"There is no defined name for '{componentType}'"),
            };
            return result;
        }
    }
}
