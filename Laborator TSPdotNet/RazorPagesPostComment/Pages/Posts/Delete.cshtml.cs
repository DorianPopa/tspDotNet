using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesPostComment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;

namespace RazorPagesPostComment.Pages.Posts
{
    public class DeleteModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        [BindProperty]
        public PostDTO PostDTO { get; set; }
        public DeleteModel()
        {
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();
            var post = await pcc.GetPostByIdAsync(id.Value);
            if (post != null)
            {
                PostDTO = new PostDTO();
                PostDTO.PostId = post.PostId;
                PostDTO.Domain = post.Domain;
                PostDTO.Description = post.Description;
                PostDTO.Date = post.Date;
                return Page();
            }
            else
                return NotFound();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int result = 0;
            // Nu pot fi sterse inregistrari parinte daca exista descendenti (cheie FK activa)
            // "Prind" exceptia si afisez o pagina cu eroare. Nu e finisat aici...
            try
            {
                result = await pcc.DeletePostAsync(id.Value);
                // result ar trebui valorificat mai departe in cod...
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Error");
            }

            return RedirectToPage("./Index");
        }
    }
}