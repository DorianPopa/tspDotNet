﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotosClientWCF
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            testControlls();
        }

        static void testControlls()
        {
            MyPhotosClient client = new MyPhotosClient();
            Application.Run(new MainWindowForm(client));
        }
    }
}
