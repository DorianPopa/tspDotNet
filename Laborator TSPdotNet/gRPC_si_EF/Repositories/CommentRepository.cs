using System;
using System.Collections.Generic;
using System.Linq;
using gRPC_si_EF.Models;
using Microsoft.Extensions.Logging;

namespace gRPC_si_EF.Repositories
{
    public class CommentRepository
    {
        private readonly ILogger<CommentRepository> _logger;
        private readonly DatabaseContext _context;

        public CommentRepository(ILogger<CommentRepository> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public virtual int AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            return _context.SaveChanges();
        }

        public virtual Comment UpdateComment(Comment newComment)
        {
            Comment oldComment = GetCommentById(newComment.CommentId);
            if (newComment.Text != null)
                oldComment.Text = newComment.Text;
            if ((oldComment.PostId != newComment.PostId) && (newComment.PostId != Guid.Empty))
                oldComment.PostId = newComment.PostId;
            _context.SaveChanges();
            return oldComment;
        }

        public virtual Comment GetCommentById(Guid id)
        {
            return _context.Comments.FirstOrDefault(c => c.CommentId == id);
        }
    }
}
