using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class FileController
    {
        private DatabaseModelContainer Context = DatabaseContext.GetContext();

        public File CreateNewFile(string path, string name = "")
        {
            Console.WriteLine("Called file create");
            File newFile = new File() { Id = Guid.NewGuid(), CreatedAt = DateTime.Now, Deleted = false, Name = name, Path = path };
            return newFile;
        }

        public File AddFile(File toBeAdded)
        {
            Console.WriteLine("Called add file");
            Context.Files.Add(toBeAdded);
            if (GetFileById(toBeAdded.Id) != null)
                return null;
            int result = Context.SaveChanges();

            if (result > 0)
            {
                Console.WriteLine("File added to database");
                return toBeAdded;
            }
            Console.WriteLine("File not added to database");
            return null;
        }

        public File GetFileById(Guid id)
        {
            Console.WriteLine("GetFileById called");
            return Context.Files.FirstOrDefault(f => f.Id == id);
        }

        public List<File> GetAllFiles()
        {
            Console.WriteLine("GetAllFiles called");
            return Context.Files.ToList();
        }

        public List<File> GetAllNonDeletedFiles()
        {
            return Context.Files.Where(f => f.Deleted == false).ToList();
        }

        public void EffectiveDeleteFile(Guid id)
        {
            Context.Files.Remove(GetFileById(id));
            Context.SaveChanges();
        }
        
        public bool DeleteFile(Guid id)
        {
            File toBeDeleted = GetFileById(id);
            int saveResult = 0;
            if (toBeDeleted != null)
            {
                toBeDeleted.Deleted = true;
                saveResult = Context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Delete file - could not find the file");
            }
            if(saveResult == 0)
            {
                Console.WriteLine("Delete file - could not delete the file");
                return false;
            }
            return true;
        }
    }
}
