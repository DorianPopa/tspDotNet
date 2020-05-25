using ServiceReferenceWCF;
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
            FileProperties = new HashSet<FilePropertyDTO>();
        }

        public FileDTO(File file)
        {
            Id = file.Id;
            Name = file.Name;
            Path = file.Path;
            CreatedAt = file.CreatedAt;
            Deleted = file.Deleted;
            FileProperties = new HashSet<FilePropertyDTO>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<FilePropertyDTO> FileProperties { get; set; }
    }
}
