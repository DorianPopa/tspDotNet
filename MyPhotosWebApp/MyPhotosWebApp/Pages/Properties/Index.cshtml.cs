using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceWCF;
using MyPhotosWebApp.Models;

namespace MyPhotosWebApp.Pages.Properties
{
    public class IndexModel : PageModel
    {
        public List<PropertyDTO> Properties { get; set; }
        public List<KeyValuePair<PropertyDTO, string>> PropertyValuePairs;
        MyPhotosClient client = new MyPhotosClient();
        public string fileName { get; set; }
        

        public IndexModel()
        {
            Properties = new List<PropertyDTO>();
            PropertyValuePairs = new List<KeyValuePair<PropertyDTO, string>>();
        }
        public async Task OnGetAsync(Guid? id)
        {
            if (id == null) return;


            Guid fileId = id.GetValueOrDefault();
            File file = await client.GetFileByIdAsync(fileId);
            FileDTO fileDTO = new FileDTO(file);
            fileName = fileDTO.Name;

            List<Property> propertiesForFile = await client.GetPropertiesForFileIdAsync(fileId);
            foreach(Property property in propertiesForFile)
            {
                PropertyDTO propertyDTO = new PropertyDTO(property);
                Properties.Add(propertyDTO);
                string propertyValue = await client.GetValueByFileIdAndPropertyIdAsync(fileId, property.Id);

                KeyValuePair<PropertyDTO, string> keyValuePair = KeyValuePair.Create<PropertyDTO, string>(propertyDTO, propertyValue);
                PropertyValuePairs.Add(keyValuePair);

            }
            PropertyValuePairs.Sort((item1, item2) => string.Compare(item1.Key.Title, item2.Key.Title));
        }
    }
}