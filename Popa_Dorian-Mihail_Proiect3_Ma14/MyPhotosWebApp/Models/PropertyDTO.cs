using ServiceReferenceWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApp.Models
{
    public class PropertyDTO
    {
        public PropertyDTO()
        {
            this.FileProperties = new HashSet<FilePropertyDTO>();
        }

        public PropertyDTO(Property property)
        {
            Id = property.Id;
            Title = property.Title;
            Description = property.Description;
            Type = property.Type;
            IsBase = property.IsBase;
        }

        public System.Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool IsBase { get; set; }

        public virtual ICollection<FilePropertyDTO> FileProperties { get; set; }
    }
}
