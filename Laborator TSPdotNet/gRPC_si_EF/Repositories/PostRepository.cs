using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gRPC_si_EF.Models;

namespace gRPC_si_EF.Repositories
{
    public class PostRepository
    {
        private readonly ILogger<PostRepository> _logger;
        private readonly DatabaseContext _context;

        public PostRepository(ILogger<PostRepository> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public virtual List<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public virtual Post GetPostById(Guid id)
        {
            return _context.Posts.FirstOrDefault(p => p.PostId == id);
        }
        
        public virtual int DeletePost(Guid id)
        {
            _context.Posts.Remove(GetPostById(id));
            return _context.SaveChanges();
        }

        public virtual int AddPost(Post post)
        {
            _context.Posts.Add(post);
            return _context.SaveChanges();
        }

        public virtual Post UpdatePost(Post newPost)
        {
            Post oldPost = GetPostById(newPost.PostId);
            if (oldPost == null)
                return null;
            oldPost.Description = newPost.Description;
            oldPost.Domain = newPost.Domain;
            oldPost.Date = newPost.Date;
            _context.SaveChanges();
            return oldPost;
        }
    }
}
