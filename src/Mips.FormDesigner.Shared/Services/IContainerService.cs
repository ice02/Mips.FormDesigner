using Mips.FormDesigner.Models;
using System.Threading.Tasks;

namespace Mips.FormDesigner.Services
{
    public interface IContainerService
    {
        ContainerDto ContainerData { get; set; }

        Task<ContainerDto> Load(string content);
        Task Save();
        Task<string> Export();
    }
}