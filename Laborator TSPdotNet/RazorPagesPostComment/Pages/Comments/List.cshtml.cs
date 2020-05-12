using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesPostComment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;

namespace RazorPagesPostComment.Pages.Comments
{
    public class ListModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        public List<CommentDTO> Comments { get; set; }
        public ListModel()
        {
            Comments = new List<CommentDTO>();
        }
        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;
            var item = await pcc.GetPostByIdAsync(id.Value);
            ViewData["Post"] = item.PostId.ToString() + " : " + item.Description.Trim();
            foreach (var cc in item.Comments)
            {
                CommentDTO cdto = new CommentDTO();
                cdto.PostPostId = cc.PostPostId;
                cdto.Text = cc.Text;
                cdto.CommentId = cc.CommentId;
                Comments.Add(cdto);
            }
        }
    }
}