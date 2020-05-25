using System;
using System.Collections.Generic;
using ServiceReferenceWCF;

namespace MyPhotosWebApp
{
    public class MockData
    {
        private static string[] FileGuids = 
        { 
            "65839dca-9196-495f-a68f-5d2ffaa74872", 
            "5c03d507-dd4d-4b66-84a1-3a1a68798e23", 
            "882ebcb4-9ce0-4f0c-9a64-81b08f34e3cc", 
            "36fbf8cf-3119-42ef-a6cf-f05bea4dc52c", 
            "7fe233d5-3964-48ea-bac5-51ce7a068d1e"
        };
        private static string[] FileNames =
        {
            "File1.png",
            "cat.jpg",
            "cat2.png",
            "spiderman.png",
            "THECAT.jpg"
        };
        private static string[] Paths =
        {
            @"C:\Users\Dorian\Desktop",
            @"C:\Users\Dorian\Pictures",
            @"C:\Users\Dorian\Documents",
            @"C:\Users\Dorian\Downloads",
            @"C:\Users\Dorian\Downloads",
        };

        private static string[] PropertyGuids =
        {
            "c54d9168-6078-4509-9dbf-9650ff4dd3b4",
            "fcfcf50c-1b6c-4a67-b24d-cc52a41813fd",
            "ad17141f-57fe-44c2-929b-af692e87a285",
            "8ff10d27-7ea1-44a7-8a55-996ee6a4fb3c",
            "db94c817-74c5-4df9-a967-7d4361a0e246"
        };

        private static string[] PropertyTitles =
        {
            "Location",
            "People",
            "Test1",
            "Test2",
            "Test3"
        };

        private static string[] PropertyDescriptions =
        {
            "Photo was taken at this location",
            "People that are in the photo",
            "test 1 description",
            "test 2 description",
            "test 3 description"
        };

        private static string[] FilePropertyIds = 
        {
            "97ff07b1-1d73-440a-9a87-70093fecdfbc",
            "0a195185-8d16-4b45-a91e-516d85e2c79f",
            "2cc903bb-19d3-432b-8954-c1c836719eed",
            "20d7251d-dce2-445d-b851-825c9bd616b2",
            "11f43776-3f50-4e5a-be84-951c883ffade"
        };

        private static int[] fpFileIdIndices = { 0, 0, 1, 1, 1 };
        private static int[] fpPropertyIndices = { 0, 1, 2, 3, 4 };

        private static string[] FilePropertyValues =
        {
            "Iasi",
            "Dorian, John",
            "test 1 value",
            "test 2 value",
            "test 3 value"
        };


        public List<File> Files { get; private set; }
        public List<Property> Properties { get; private set; }
        public List<FileProperty> FileProperties { get; private set; }

        public MockData()
        {
            Files = CreateMockFiles();
            Properties = CreateMockProperties();
            FileProperties = CreateMockFileProperties();
        }

        public static List<File> CreateMockFiles()
        {
            List<File> mockFiles = new List<File>();
            for(int i = 0; i < 5; i++)
            {
                File file = new File();

                file.Id = Guid.Parse(FileGuids[i]);
                file.Name = FileNames[i];
                file.Path = Paths[i] + @"\" + FileNames[i];
                file.Deleted = false;
                file.CreatedAt = DateTime.Now;

                mockFiles.Add(file);
            }
            return mockFiles;
        }

        public static List<Property> CreateMockProperties()
        {
            List<Property> mockProperties = new List<Property>();
            for (int i = 0; i < 5; i++)
            {
                Property property = new Property();

                property.Id = Guid.Parse(PropertyGuids[i]);
                property.Title = PropertyTitles[i];
                property.Description = PropertyDescriptions[i];
                property.IsBase = false;
                if (i < 2) property.IsBase = true;
                property.Type = "string";

                mockProperties.Add(property);
            }
            return mockProperties;
        }

        public static List<FileProperty> CreateMockFileProperties()
        {
            List<FileProperty> mockFileProperties = new List<FileProperty>();
            for(int i = 0; i < 5; i++)
            {
                FileProperty fp = new FileProperty();
                fp.Id = Guid.Parse(FilePropertyIds[i]);
                fp.FileId = Guid.Parse(FileGuids[fpFileIdIndices[i]]);
                fp.PropertyId = Guid.Parse(PropertyGuids[fpPropertyIndices[i]]);
                fp.Value = FilePropertyValues[i];

                mockFileProperties.Add(fp);
            }
            return mockFileProperties;
        }

        public List<Property> GetAllProperties()
        {
            //return CreateMockProperties();
            return Properties;
        }

        public List<File> GetAllFiles()
        {
            //return CreateMockFiles();
            return Files;
        }

        public List<Property> GetAllPropertiesForFileId(Guid id)
        {
            List<Property> returnList = new List<Property>();
            if (id.Equals(Guid.Parse(FileGuids[0])))
            {
                return Properties.FindAll(p => (p.Id.Equals(Guid.Parse(PropertyGuids[0])) || p.Id.Equals(Guid.Parse(PropertyGuids[1]))));
            }
            else if (id.Equals(Guid.Parse(FileGuids[1])))
            {
                return Properties.FindAll(p => (p.Id.Equals(Guid.Parse(PropertyGuids[2])) || p.Id.Equals(Guid.Parse(PropertyGuids[3])) || p.Id.Equals(Guid.Parse(PropertyGuids[4]))));
            }
            return new List<Property>();
        }

        public File GetFileById(Guid id)
        {
            return Files.Find(f => (f.Id.Equals(id)));
        }

        public string GetValueByFileIdAndPropertyId(Guid fileId, Guid propertyId)
        {
            return FileProperties.Find(fp => (fp.FileId.Equals(fileId) && fp.PropertyId.Equals(propertyId))).Value;
        }
    }
}
