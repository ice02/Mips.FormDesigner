using Mips.FormDesigner.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mips.FormDesigner.Services
{
    public interface IFormsService
    {
        Task<ContainerDto> LoadContainer(Guid formId);
        Task<IEnumerable<FormDto>> ListForms(string namefilter);
    }
}