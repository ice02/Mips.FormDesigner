using System;

namespace Mips.FormDesigner.Models
{
    public class ComponentBaseDto
    {
        public ComponentBaseDto()
        {
            Id = Guid.NewGuid();
        }

        public ComponentBaseDto(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
