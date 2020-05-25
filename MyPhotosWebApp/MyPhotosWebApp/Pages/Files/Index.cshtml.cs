using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPhotosWebApp.Models;
using ServiceReferenceWCF;

namespace MyPhotosWebApp.Pages.Files
{
    public class IndexModel : PageModel
    {
        public List<FileDTO> Files { get; set; }
        public MyPhotosClient client = new MyPhotosClient();

        public List<string> searchableProperties { get; set; }
        public SelectList filterPropertyList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public int searchResults { get; set; }

        public IndexModel()
        {
            Files = new List<FileDTO>();
            searchResults = 0;
        }

        public async Task OnGetAsync()
        {
            var allProperties = await client.GetAllPropertiesAsync();
            foreach(Property p in allProperties)
            {
                searchableProperties.Add(p.Title);
            }
            filterPropertyList = new SelectList(searchableProperties);

            var allFiles = await client.GetAllFilesAsync();
            foreach(File file in allFiles)
            {
                FileDTO fileDTO = new FileDTO(file);
                var propertiesForFile = await client.GetPropertiesForFileIdAsync(file.Id);

                bool matchedBySearch = false;
                foreach(Property property in propertiesForFile)
                {
                    PropertyDTO propertyDTO = new PropertyDTO(property);
                    if (!string.IsNullOrEmpty(SearchString))
                    {
                        if (propertyDTO.Title == SearchString)
                            matchedBySearch = true;
                    }
                    else
                        matchedBySearch = true;
                }
                if (matchedBySearch)
                {
                    searchResults++;
                    Files.Add(fileDTO);
                }
            }
        }
    }
}