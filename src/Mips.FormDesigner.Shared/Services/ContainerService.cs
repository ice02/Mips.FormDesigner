using Mips.FormDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mips.FormDesigner.Services
{
    public class ContainerService : IContainerService
    {
        public ContainerService() { }

        public ContainerDto ContainerData { get; set; }

        public async Task Save()
        { }

        public async Task<ContainerDto> Load(string content)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());

            var rows = JsonSerializer.Deserialize<List<List<ComponentDto>>>(content, options);

            return new ContainerDto(rows);
        }

        public async Task<string> Export()
        {
            return ContainerData.JSonValues();
        }
    }
}
