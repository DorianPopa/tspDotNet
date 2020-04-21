using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotos;

namespace MyPhotosWCF
{
    public class MyPhotosService : IMyPhotos
    {
        private FileController fileController = new FileController();
        private PropertyController propertyController = new PropertyController();
        private FilePropertyController filePropertyController = new FilePropertyController();

        File InterfaceFile.AddFile(File toBeAdded)
        {
            return fileController.AddFile(toBeAdded);
        }

        FileProperty InterfaceFileProperty.AddFilePropertyToFile(FileProperty fileProperty)
        {
            return filePropertyController.AddFilePropertyToFile(fileProperty);
        }

        Property InterfaceProperty.AddProperty(Property toBeAdded)
        {
            return propertyController.AddProperty(toBeAdded);
        }

        FileProperty InterfaceFileProperty.CreateFileProperty(Guid fileID, Guid propertyId, string value)
        {
            return filePropertyController.CreateFileProperty(fileID, propertyId, value);
        }

        File InterfaceFile.CreateNewFile(string path, string name)
        {
            return fileController.CreateNewFile(path, name);
        }

        Property InterfaceProperty.CreateProperty(string title, string description, string type)
        {
            return propertyController.CreateProperty(title, description, type);
        }

        bool InterfaceFile.DeleteFile(Guid id)
        {
            return fileController.DeleteFile(id);
        }

        void InterfaceProperty.DeleteProperty(Guid id)
        {
            propertyController.DeleteProperty(id);
        }

        Property InterfaceProperty.EditProperty(Guid id, string title, string description)
        {
            return propertyController.EditProperty(id, title, description);
        }

        void InterfaceFile.EffectiveDeleteFile(Guid id)
        {
            fileController.EffectiveDeleteFile(id);
        }

        List<File> InterfaceFile.GetAllFiles()
        {
            return fileController.GetAllFiles();
        }

        List<File> InterfaceFile.GetAllNonDeletedFiles()
        {
            return fileController.GetAllNonDeletedFiles();
        }

        List<Property> InterfaceProperty.GetAllProperties()
        {
            return propertyController.GetAllProperties();
        }

        File InterfaceFile.GetFileById(Guid id)
        {
            return fileController.GetFileById(id);
        }

        List<Property> InterfaceFileProperty.GetPropertiesForFileId(Guid id)
        {
            return filePropertyController.GetPropertiesForFileId(id);
        }

        Property InterfaceProperty.GetPropertyById(Guid id)
        {
            return propertyController.GetPropertyById(id);
        }

        Property InterfaceProperty.GetPropertyByTitle(string title)
        {
            return propertyController.GetPropertyByTitle(title);
        }

        string InterfaceFileProperty.GetValueByFileIdAndPropertyId(Guid fileId, Guid propertyId)
        {
            return filePropertyController.GetValueByFileIdAndPropertyId(fileId, propertyId);
        }

        void InterfaceProperty.InitializeDefaultProperties()
        {
            propertyController.InitializeDefaultProperties();
        }

        void InterfaceFileProperty.RemovePropertyForFile(Guid propertyId, Guid fileId)
        {
            filePropertyController.RemovePropertyForFile(propertyId, fileId);
        }

        bool InterfaceProperty.ValidateDataType(string dataType, string value)
        {
            return propertyController.ValidateDataType(dataType, value);
        }
    }
}
