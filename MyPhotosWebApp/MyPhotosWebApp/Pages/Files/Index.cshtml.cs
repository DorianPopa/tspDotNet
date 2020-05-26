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
            MockData data = new MockData();

            //var allProperties = await client.GetAllPropertiesAsync();
            var allProperties = data.GetAllProperties();

            searchableProperties = new List<string>();
            foreach (Property p in allProperties)
            {
                searchableProperties.Add(p.Title);
            }
            filterPropertyList = new SelectList(searchableProperties);

            //var allFiles = await client.GetAllFilesAsync();
            var allFiles = data.GetAllFiles();

            foreach(File file in allFiles)
            {
                FileDTO fileDTO = new FileDTO(file);
                List<Property> propertiesOfFile = data.GetAllPropertiesForFileId(file.Id);
                if (!string.IsNullOrEmpty(SearchString))
                {
                    if (propertiesOfFile.Find(p => p.Title.Equals(SearchString)) != null)
                    {
                        Files.Add(fileDTO);
                    }
                }
                else
                {
                    Files.Add(fileDTO);
                }
            }
            searchResults = Files.Count;
        }
    }
}