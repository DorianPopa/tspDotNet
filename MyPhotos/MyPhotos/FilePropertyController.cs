using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class FilePropertyController
    {
        private DatabaseModelContainer Context = DatabaseContext.GetContext();
        private FileController FileController = new FileController();
        private PropertyController PropertyController = new PropertyController();


        public FileProperty CreateFileProperty(Guid fileID, Guid propertyId, string value = "")
        {
            Console.WriteLine("CreateFileProperty called");
            File file = FileController.GetFileById(fileID);
            Property property = PropertyController.GetPropertyById(propertyId);

            if (file == null || property == null)
                return null;

            if (!PropertyController.ValidateDataType(property.Type, value))
                return null;

            FileProperty newFileProperty = new FileProperty() { 
                Id = Guid.NewGuid(), 
                File = file,
                FileId = file.Id,
                Property = property,
                PropertyId = property.Id,
                Value = value
            };

            return newFileProperty;
        }

        public FileProperty AddFilePropertyToFile(FileProperty fileProperty)
        {
            Console.WriteLine("AddPropertyToFile called");
            if (fileProperty == null)
                return null;

            Context.FileProperties.Add(fileProperty);
            int result = Context.SaveChanges();
            if (result > 0)
                return fileProperty;
            return null;
        }

        public List<Property> GetPropertiesForFileId(Guid id)
        {
            Console.WriteLine("GetPropertiesForFileId called");
            List<FileProperty> fileProperties = Context.FileProperties.Where(fp => fp.FileId == id).ToList();
            List<Property> properties = new List<Property>();
            foreach(FileProperty fp in fileProperties)
            {
                properties.AddRange(Context.Properties.Where(p => p.Id == fp.PropertyId).ToList());
            }
            return properties;
        }

        public string GetValueByFileIdAndPropertyId(Guid fileId, Guid propertyId)
        {
            Console.WriteLine("GetValueByFileIdAndPropertyId called");
            FileProperty fileProperty = Context.FileProperties.FirstOrDefault(fp => fp.FileId == fileId && fp.PropertyId == propertyId);
            string value = "";
            if(fileProperty != null)
                value = fileProperty.Value;
            return value;
        }

        public void RemovePropertyForFile(Guid propertyId, Guid fileId)
        {
            FileProperty toBeRemoved = Context.FileProperties.FirstOrDefault(fp => fp.FileId == fileId && fp.PropertyId == propertyId);
            Context.FileProperties.Remove(toBeRemoved);
            Context.SaveChanges();
        }
    }
}
