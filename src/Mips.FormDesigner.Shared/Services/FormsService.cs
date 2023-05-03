using Mips.FormDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mips.FormDesigner.Services
{
    public class FormsService : IFormsService
    {
        FormDto[] forms = new[]
        {
            new FormDto(new Guid("639D4AEA-7539-4C8F-94D5-B5951084E207"), "0 Test") { Content = "[[{\"$type\":\"Checkbox\",\"IsChecked\":false,\"Parent\":null,\"Type\":\"Checkbox\",\"Label\":\"Teams\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":2,\"Id\":\"e2760635-5a43-49ae-958e-99562069d107\"},{\"$type\":\"Checkbox\",\"IsChecked\":false,\"Parent\":null,\"Type\":\"Checkbox\",\"Label\":\"Sharepoint\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":2,\"Id\":\"85a1403b-9c3a-49b3-8304-5c75f8ab2e45\"},{\"$type\":\"Checkbox\",\"IsChecked\":false,\"Parent\":null,\"Type\":\"Checkbox\",\"Label\":\"Yammer\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":2,\"Id\":\"19598233-f4ab-44a1-8894-53b475c3c20b\"},{\"$type\":\"Checkbox\",\"IsChecked\":false,\"Parent\":null,\"Type\":\"Checkbox\",\"Label\":\"Exchange\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":2,\"Id\":\"3faccc24-03a1-4450-b91d-84a8e571679d\"},{\"$type\":\"Checkbox\",\"IsChecked\":false,\"Parent\":null,\"Type\":\"Checkbox\",\"Label\":\"Azure AD\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":2,\"Id\":\"32e1374e-a250-4107-9332-c4703c5586c6\"},{\"$type\":\"Checkbox\",\"IsChecked\":false,\"Parent\":null,\"Type\":\"Checkbox\",\"Label\":\"Other\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":2,\"Id\":\"6cc9f3cf-2109-46b9-9620-eec9d4762074\"}],[{\"Parent\":null,\"Type\":\"File\",\"Label\":\"Certificate\",\"IsMandatory\":true,\"ChildContainers\":null,\"Width\":12,\"Id\":\"9d438093-381a-4fc4-b07c-762d04805def\"}],[{\"Parent\":null,\"Type\":\"Email\",\"Label\":\"Mailing list\",\"IsMandatory\":true,\"ChildContainers\":null,\"Width\":12,\"Id\":\"43f9a9d0-3f3e-457f-87d9-b0b501b9694b\"}]]" },
            new FormDto(new Guid("369D4AE5-453A-2C81-A4D5-A9651084E5A2"), "First Test") { Content = "[[{\"Parent\":null,\"Type\":0,\"Label\":\"Singel Line 1\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":6,\"Id\":\"a7800297-afba-46d3-8f20-7bbf6fe67e4f\"},{\"Parent\":null,\"Type\":1,\"Label\":\"Multi Line 1\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":6,\"Id\":\"de8813dd-9011-497c-8f83-9e1d1b014a5f\"}],[{\"Parent\":null,\"Type\":5,\"Label\":\"Number 1\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":12,\"Id\":\"78b2d80e-a922-4625-a480-b6070f4a751f\"}]]" },
            new FormDto(new Guid("539D4AEF-353B-9C8E-34D5-53751084E4BE"), "Second Test") { Content = "[[{\"Parent\":null,\"Type\":11,\"Label\":\"DropDownList-98fa33bb-0b3d-4e12-a231-8e0be789bc63\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":6,\"Id\":\"5cfb89b5-feda-4aef-8d24-473647d8f216\"},{\"Parent\":null,\"Type\":1,\"Label\":\"Multi Line 1\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":6,\"Id\":\"de8813dd-9011-497c-8f83-9e1d1b014a5f\"}],[{\"Parent\":null,\"Type\":3,\"Label\":\"Email-634b8ca7-135c-4469-b21d-e16f89e181b5\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":6,\"Id\":\"14ef6f64-a776-44dc-8ee8-988831564bc4\"},{\"Parent\":null,\"Type\":2,\"Label\":\"Link-40f82802-106a-439e-ba18-33e0a5e57075\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":6,\"Id\":\"0c96001d-c768-42f7-9d6b-0ca9c43ab42d\"}],[{\"Parent\":null,\"Type\":5,\"Label\":\"Number 1\",\"IsMandatory\":false,\"ChildContainers\":null,\"Width\":12,\"Id\":\"78b2d80e-a922-4625-a480-b6070f4a751f\"}]]" }
        };

        private readonly IContainerService _containerService;

        public FormsService(IContainerService containerService)
        {
            _containerService = containerService;
        }

        public async Task<IEnumerable<FormDto>> ListForms(string namefilter)
        {
            //TODO: on API filter on owner
            //TODO: replace by DB reading throught API
            return forms.Select(p=> new FormDto(p.ID, p.Name));
        }

        public async Task<ContainerDto> LoadContainer(Guid formId)
        {
            //TODO: replace by DB reading throught API
            var content = forms.FirstOrDefault(p => p.ID == formId)?.Content;
            ContainerDto container = null;

            if (!string.IsNullOrEmpty(content))
            {
                container = await _containerService.Load(content);
            }

            return container;
        }
    }
}
