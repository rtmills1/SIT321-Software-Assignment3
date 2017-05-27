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
        #region Configuration
        private const string _PASSWORDS_FILENAME = "Users.bin";

        private static string[] _LoginBanner = new string[]
        {
            "",
            "*************************************************",
            "***** SIT321 - Just change the banner later *****",
            "*************************************************",
            "",
            "Please login below or enter 'exit' to terminate.",
            ""
        };

        private static string _LoginTerminator = "exit";
        #endregion


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string pwFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + _PASSWORDS_FILENAME;
            bool dbExists = false;
            try
            {
                UserManager.LoadDB(pwFile);
                dbExists = true;
            }
            catch (UserDBIOException e)
            {
                if (e.InnerException != null && e.InnerException is FileNotFoundException)
                {
                    UserManager.SeedDB();
                    dbExists = true;
                }
                else
                {
                    Console.WriteLine("Error: {0}{1}", e.Message, e.InnerException != null ? string.Format(" ({0})", e.InnerException.Message) : "");
                }
            }

            if (dbExists)
            {
                UserManager.SaveDB(pwFile);
            }
        }
    }
}
