using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class PropertyController
    {
        private DatabaseModelContainer Context = DatabaseContext.GetContext();
        private readonly string[] _defaultProperties = {
            "Place",
            "People",
            "Capture Date"
        };
        private readonly string[] _defaultPropertiesDescription = {
            "The place the photo / movie was taken",
            "The people that are in the photo",
            "The capture / recording date"
        };
        private readonly string[] _defaultPropertiesTypes =
        {
            "string",
            "string",
            "DateTime"
        };

        public PropertyController()
        {
            Console.WriteLine("Called PropertyController constructor");
            InitializeDefaultProperties();
        }

        public Property CreateProperty(string title, string description, string type)
        {
            Console.WriteLine("CreateProperty called");
            Property property = new Property() { Id = Guid.NewGuid(), Title = title, Description = description, Type = type, IsBase = false };
            return property;
        }

        public void InitializeDefaultProperties()
        {
            Console.WriteLine("InitDefaultProperties called");
            int saveResult = 0;

            for(int i = 0; i < _defaultProperties.Length; i++)
            {
                string defaultPropertyName = _defaultProperties[i];
                Property property = Context.Properties.FirstOrDefault(p => p.Title == defaultPropertyName);
                if(property == null)
                {
                    property = new Property() {
                        Id = Guid.NewGuid(),
                        Title = _defaultProperties[i],
                        Description = _defaultPropertiesDescription[i],
                        Type = _defaultPropertiesTypes[i],
                        IsBase = true
                    };
                    Context.Properties.Add(property);
                    saveResult += Context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(@"Default property with name {0} already exists in the database", _defaultProperties[i]);
                }
            }
            if (saveResult != _defaultProperties.Length + 1)
                Console.WriteLine("Could not save default properties");
        }

        public Property AddProperty(Property toBeAdded)
        {
            Console.WriteLine("Called add property");
            Property p = GetPropertyByTitle(toBeAdded.Title);
            if (p != null)
                return null;

            Context.Properties.Add(toBeAdded);
            int result = Context.SaveChanges();

            if (result > 0)
            {
                Console.WriteLine("Property added to database");
                return toBeAdded;
            }
            Console.WriteLine("Property not added to database");
            return null;
        }

        public Property GetPropertyByTitle(string title)
        {
            Console.WriteLine("GetPropertyByTitle called");
            return Context.Properties.FirstOrDefault(p => p.Title == title);
        }

        public Property GetPropertyById(Guid id)
        {
            Console.WriteLine("GetPropertyById called");
            return Context.Properties.FirstOrDefault(p => p.Id == id);
        }

        public List<Property> GetAllProperties()
        {
            List <Property> debugList = Context.Properties.ToList();
            return debugList;
        }

        public Property EditProperty(Guid id, string title = "", string description = "")
        {
            Property toBeUpdated = GetPropertyById(id);
            if (toBeUpdated != null)
            {
                if (title != "")
                    toBeUpdated.Title = title;  
                if (description != "")
                    toBeUpdated.Description = description;
                int result = Context.SaveChanges();
                if (result > 0)
                    return toBeUpdated;
            }
            return null;
        }

        public void DeleteProperty(Guid id)
        {
            Context.Properties.Remove(GetPropertyById(id));
            Context.SaveChanges();
        }

        public bool ValidateDataType(string dataType, string value)
        {
            if (dataType == "int")
            {
                int intValue = Int32.MinValue;
                try
                {
                    intValue = Convert.ToInt32(value);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            else if (dataType == "DateTime")
            {
                DateTime dateTime;
                try
                {
                    dateTime = DateTime.Parse(value);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
            else if (dataType == "string")
            {
                return true;
            }
            else 
                return false;
        }
    }
}
