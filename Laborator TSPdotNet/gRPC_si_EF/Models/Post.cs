using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gRPC_si_EF.Models
{
    public class Post
    {
        [Required]
        public Guid PostId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Domain { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
