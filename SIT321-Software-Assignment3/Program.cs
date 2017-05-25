using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using SIT321_Software_Assignment3.Users;
using SIT321_Software_Assignment3.Exceptions;

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
        #region Login Management
        private static User GetLogin()
        {
            string login;
            string pass;
            ConsoleKeyInfo cki;
            User ret = null;
            do
            {
                try
                {
                    foreach (string s in _LoginBanner)
                        Console.WriteLine(s);

                    Console.Write("login: ");
                    login = Console.ReadLine();
                    if (login.ToLower() == _LoginTerminator.ToLower())
                        break;
                    Console.Write("password: ");
                    pass = "";
                    while ((cki = Console.ReadKey(true)) != null)
                    {
                        if (cki.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine();
                            break;
                        }
                        else
                            pass += cki.KeyChar;
                    }
                    if ((ret = UserManager.ValidateLogin(login, pass)) == null)
                        Console.Error.WriteLine("Invalid login.");
                }
                catch (SIT321_Software_Assignment3.Exceptions.EasyLibraryException ex)
                {
                    Console.Error.WriteLine("Error: {0}", ex.Message);
                }
                Console.WriteLine();
            } while (ret == null);

            return ret;
        }
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
                User user;
                while ((user = GetLogin()) != null)
                {
                    List<SIT321_Software_Assignment3.Menus.MenuOption> menu = SIT321_Software_Assignment3.Menus.MenuSystem.GetMenu(user);
                    SIT321_Software_Assignment3.Menus.MenuSystem.RunMenu(user, menu);
                    Console.WriteLine("\nLife is pain");
                }

                UserManager.SaveDB(pwFile);
            }
        }
    }
}
