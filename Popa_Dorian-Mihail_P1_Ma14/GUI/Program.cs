using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos;

namespace MyPhotosClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddNewFileForm());
            //testAPI();
            testControlls();
        }

        static void testControlls()
        {
            FileController fileC = new FileController();
            File file = fileC.CreateNewFile(@"C:\Users\Dorian\Desktop\yuumi.PNG", "Catt");
            Application.Run(new MainWindowForm());
            //Application.Run(new AddNewFileForm(file, null));
        }

        static void testAPI()
        {
            FileController fileC = new FileController();
            PropertyController propertyC = new PropertyController();

            //File testFile = fileC.CreateNewFile(@"C:\Users\Dorian\Pictures\1605383.jpg", "Illidan Picture");
            //testFile = fileC.AddFile(testFile);
            //fileC.DeleteFile(testFile.Id);

            Property newProperty = propertyC.CreateProperty("Characters", "The characters that are in the photo", "string");
            newProperty = propertyC.AddProperty(newProperty);
        }
    }
}
