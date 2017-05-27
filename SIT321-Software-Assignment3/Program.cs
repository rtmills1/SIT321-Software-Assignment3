using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using SIT321_Software_Assignment3.Users;
using SIT321_Software_Assignment3.Exceptions;
using SIT321_Software_Assignment3.Subsystems;

namespace SIT321_Software_Assignment3
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
