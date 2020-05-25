using ServiceReferenceWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApp.Models
{
    public class FilePropertyDTO
    {

        public FilePropertyDTO(FileProperty fileProperty)
        {
            Id = fileProperty.Id;
            FileId = fileProperty.FileId;
            PropertyId = fileProperty.PropertyId;
            Value = fileProperty.Value;
        }

        public System.Guid Id { get; set; }
        public System.Guid FileId { get; set; }
        public System.Guid PropertyId { get; set; }
        public string Value { get; set; }

        public virtual FileDTO File { get; set; }
        public virtual PropertyDTO Property { get; set; }
    }
}
