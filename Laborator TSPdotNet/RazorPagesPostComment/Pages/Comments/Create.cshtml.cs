using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesPostComment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;

namespace RazorPagesPostComment.Pages.Comments
{
    public class CreateModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        public CreateModel()
        {
            CommentDTO = new CommentDTO();
        }
        [BindProperty]
        public CommentDTO CommentDTO { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id.HasValue)
            {
                var itemPost = await pcc.GetPostByIdAsync(id.Value);
                ViewData["id"] = id.Value.ToString() + " : " + itemPost.Description;
                CommentDTO.PostPostId = id.Value;
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Comment comment = new Comment(); // acest tip este vazut in serviciu
            int postId = 0;
            postId = id.Value;
            comment.PostPostId = postId;
            comment.Text = CommentDTO.Text;
            var result = await pcc.AddCommentAsync(comment);
            if (!result)
            {
                return RedirectToAction("Error");
            }
            return RedirectToPage("/Posts/Index");
        }
    }
}