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
    public class CreateModel : PageModel
    {
        MyPhotosClient client = new MyPhotosClient();

        [BindProperty]
        public PropertyDTO PropertyDTO { get; set; }

        public IActionResult OnGet()
        {
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
            return RedirectToPage("./Index");
        }
    }
}