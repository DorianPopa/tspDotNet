using System;
using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos;

namespace MyPhotosWCF
{
    [ServiceContract]
    interface InterfaceFile
    {
        [OperationContract]
        File CreateNewFile(string path, string name = "");

        [OperationContract]
        File AddFile(File toBeAdded);

        [OperationContract]
        File GetFileById(Guid id);

        [OperationContract]
        List<File> GetAllFiles();

        [OperationContract]
        List<File> GetAllNonDeletedFiles();

        [OperationContract]
        void EffectiveDeleteFile(Guid id);

        [OperationContract]
        bool DeleteFile(Guid id);
    }

    [ServiceContract]
    interface InterfaceProperty
    {
        [OperationContract]
        Property CreateProperty(string title, string description, string type);

        [OperationContract]
        void InitializeDefaultProperties();

        [OperationContract]
        Property AddProperty(Property toBeAdded);

        [OperationContract]
        Property GetPropertyByTitle(string title);

        [OperationContract]
        Property GetPropertyById(Guid id);

        [OperationContract]
        List<Property> GetAllProperties();

        [OperationContract]
        Property EditProperty(Guid id, string title = "", string description = "");

        [OperationContract]
        void DeleteProperty(Guid id);

        [OperationContract]
        bool ValidateDataType(string dataType, string value);
    }

    [ServiceContract]
    interface InterfaceFileProperty
    {
        [OperationContract]
        FileProperty CreateFileProperty(Guid fileID, Guid propertyId, string value = "");

        [OperationContract]
        FileProperty AddFilePropertyToFile(FileProperty fileProperty);

        [OperationContract]
        List<Property> GetPropertiesForFileId(Guid id);

        [OperationContract]
        string GetValueByFileIdAndPropertyId(Guid fileId, Guid propertyId);

        [OperationContract]
        void RemovePropertyForFile(Guid propertyId, Guid fileId);
    }

    [ServiceContract]
    interface IMyPhotos : InterfaceFile, InterfaceProperty, InterfaceFileProperty 
    { 

    }
}
