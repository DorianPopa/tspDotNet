using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Popa_Dorian_Mihail_Rp.Data;
using ASP_Popa_Dorian_Mihail_Rp.Models;

namespace ASP_Popa_Dorian_Mihail_Rp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly ASP_Popa_Dorian_Mihail_Rp.Data.ASP_Popa_Dorian_Mihail_RpContext _context;

        public DetailsModel(ASP_Popa_Dorian_Mihail_Rp.Data.ASP_Popa_Dorian_Mihail_RpContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
