﻿using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mips.FormDesigner.Models
{
    public class ContainerDto : ContainerBaseDto
    {
        public ContainerDto()
        {
            InitEmptyContainer(ref Rows);
        }

        public ContainerDto(Guid id) : base(id)
        {
            InitEmptyContainer(ref Rows);
        }

        public ContainerDto(Guid id, List<List<ComponentDto>> rows) : base(id)
        {
            Rows = rows;
        }

        public ContainerDto(Guid id, ContainerType type) : base(id, type)
        {
            InitEmptyContainer(ref Rows);
        }

        public ContainerDto(Guid id, ContainerType type, List<List<ComponentDto>> rows)
            : base(id, type)
        {
            Rows = rows;
        }

        public ContainerDto(ContainerType type) : base(type)
        {
            InitEmptyContainer(ref Rows);
        }

        public ContainerDto(List<List<ComponentDto>> rows)
        {
            Rows = rows;
        }

        internal void InitEmptyContainer(ref List<List<ComponentDto>> rows)
        {
            rows = new List<List<ComponentDto>>()
            {
                new List<ComponentDto>()
            };
        }

        internal string JSonValues()
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            return JsonSerializer.Serialize(Rows, options);
        }

        public string Label { get; set; }
        
        public readonly List<List<ComponentDto>> Rows;
    }
}
