using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace gRPC_si_EF.Models
{
    public class Comment
    {
        [Required]
        public Guid CommentId { get; set; }

        [Required]
        public string Text { get; set; }

        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
