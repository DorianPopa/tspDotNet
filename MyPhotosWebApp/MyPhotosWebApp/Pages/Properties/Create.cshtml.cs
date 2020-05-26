using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceWCF;
using MyPhotosWebApp.Models;

namespace MyPhotosWebApp.Pages.Properties
{
    public class CreateModel : PageModel
    {
        public MyPhotosClient client = new MyPhotosClient();
        public Guid FileId { get; set; }

        [BindProperty]
        public PropertyDTO PropertyDTO { get; set; }

        [BindProperty]
        public string Value { get; set; }

        public async Task<IActionResult> OnGet(Guid? id)
        {
            FileId = id.GetValueOrDefault();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            Property property = new Property();
            property.Title = PropertyDTO.Title;
            property.Description = PropertyDTO.Description;
            property.Type = PropertyDTO.Type;
            var result = await client.AddPropertyAsync(property);
            if (result == null)
            {
                return RedirectToAction("Error");
            }

            var result2 = await client.CreateFilePropertyAsync(FileId, result.Id, Value);
            if (result2 == null)
            {
                return RedirectToAction("Error");
            }

            return RedirectToPage("./Index");
        }
    }
}