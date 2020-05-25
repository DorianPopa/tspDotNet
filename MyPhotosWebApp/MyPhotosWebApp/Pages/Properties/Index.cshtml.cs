using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceWCF;
using MyPhotosWebApp.Models;

namespace MyPhotosWebApp.Pages.Properties
{
    public class IndexModel : PageModel
    {
        MyPhotosClient client = new MyPhotosClient();
        public List<PropertyDTO> Properties { get; set; }

        public IndexModel()
        {
            Properties = new List<PropertyDTO>();
        }
        public async Task OnGetAsync()
        {
            var properties = await client.GetAllPropertiesAsync();
            foreach(var property in properties)
            {
                PropertyDTO pDTO = new PropertyDTO();
                pDTO.Title = property.Title;
                pDTO.Description = property.Description;
                pDTO.Type = property.Type;
                foreach(FileProperty fp in property.FileProperties)
                {
                    FilePropertyDTO fpDTO = new FilePropertyDTO();
                    fpDTO.FileId = fp.FileId;
                    fpDTO.PropertyId = fp.PropertyId;
                    fpDTO.Value = fpDTO.Value;
                    pDTO.FileProperties.Add(fpDTO);
                }
                Properties.Add(pDTO);
            }
            Properties.Sort((p1, p2) => string.Compare(p1.Title, p2.Title));
        }
    }
}