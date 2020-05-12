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
    public class IndexModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        public List<PostDTO> Posts { get; set; }

        public IndexModel()
        {
            Posts = new List<PostDTO>();
        }
        public async Task OnGetAsync()
        {
            var posts = await pcc.GetPostsAsync();
            foreach (var item in posts)
            {
                // Trebuia folosit AutoMapper. Transform Post in PostDTO
                PostDTO pd = new PostDTO();
                pd.Description = item.Description;
                pd.PostId = item.PostId;
                pd.Domain = item.Domain;
                pd.Date = item.Date;
                foreach (var cc in item.Comments)
                {
                    CommentDTO cdto = new CommentDTO();
                    cdto.PostPostId = cc.PostPostId;
                    cdto.Text = cc.Text;
                    pd.Comments.Add(cdto);
                }
                Posts.Add(pd);
            }
        }
    }
}
