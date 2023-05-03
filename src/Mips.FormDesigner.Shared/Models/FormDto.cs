using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mips.FormDesigner.Models
{
    public class FormDto
    {
        

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int SerializerVersion { get; set; }

        public FormDto(Guid guid, string name)
        {
            Name = name;
            ID = guid;
            SerializerVersion = 1;
        }
    }
}
