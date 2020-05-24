using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApp.Models
{
    public class FileDTO
    {   
        public FileDTO()
        {
            this.FileProperties = new HashSet<FilePropertyDTO>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<FilePropertyDTO> FileProperties { get; set; }
    }
}
