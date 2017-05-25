using SIT321_Software_Assignment3.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SIT321_Software_Assignment3.Menus
{
    public static class MenuSystem
    {
        //Need to add more/an option(s) here for student and lecturer. The admin is already there
        //Currently all the users have the same privledges.
        private static MenuOption GetMenuSelection(List<MenuOption> menuOptions, User currentUser)
        {
            MenuOption result = null;

            string greeting = string.Format("Welcome {0}", currentUser);
            Console.WriteLine(greeting);
            Console.WriteLine(new string('=', greeting.Length));

            bool valid = false;
            string selectedOption = "";
            while (valid == false)
            {
                Console.WriteLine("Please select from the following options:");
                foreach (MenuOption opt in menuOptions)
                {
                    Console.WriteLine("\t{0}. {1}", opt.Option, opt.Description);
                }
                Console.Write("Please enter your selection: ");
                selectedOption = Console.ReadLine().ToUpper();
                result = menuOptions.Where(m => m.Option == selectedOption).SingleOrDefault<MenuOption>();
                if (result != null)
                    valid = true;
                else
                    Console.Error.WriteLine("Invalid option, please try again.");
            }
            Console.WriteLine();

            return result;
        }

        public static void RunMenu(User currentUser, List<MenuOption> menu)
        {
            MenuOption opt;
            ExtendedResult extResult = new ExtendedResult(ResultCode.None);

            do
            {
                try
                {
                    opt = GetMenuSelection(menu, currentUser);
                    opt.Handler(currentUser, out extResult);
                    if (extResult.ResultCode == ResultCode.SubMenu)
                        RunMenu(currentUser, extResult.SubMenu);
                }
                catch (SIT321_Software_Assignment3.Exceptions.EasyLibraryException ex)
                {
                    Console.Error.WriteLine("Error: {0}", ex.Message);
                }
            } while (extResult.ResultCode != ResultCode.Logout);
        }

        #region General Handler Functions
        
        private static void NoopHandler(User usr, out ExtendedResult result)
        {
            result = new ExtendedResult(ResultCode.None);
        }

        private static void LogoutHandler(User usr, out ExtendedResult result)
        {
            result = new ExtendedResult(ResultCode.Logout);
        }
        #endregion

        #region User Management Handlers
        private static void AddUserHandler(User usr, out ExtendedResult result)
        {
            Console.WriteLine("Please select from the following types of user: ");
            Console.WriteLine("\t1) Administrator");
            Console.WriteLine("\t2) Lecturer");
            Console.WriteLine("\t3) Student");
            Console.WriteLine("\t0) Go back");
            Console.Write("Selection: ");

            User newUsr = null;
            int selection;
            if (int.TryParse(Console.ReadLine(), out selection) == true)
            {
                switch (selection)
                {
                    case 1: // Administrator
                        newUsr = SIT321_Software_Assignment3.Subsystems.AutoPrompt.Create<SIT321_Software_Assignment3.Users.Admin>();
                        break;
                    case 2: // Lecturer
                        newUsr = SIT321_Software_Assignment3.Subsystems.AutoPrompt.Create<SIT321_Software_Assignment3.Users.Lecturer>();
                        break;
                    case 3: // Student
                        newUsr = SIT321_Software_Assignment3.Subsystems.AutoPrompt.Create<SIT321_Software_Assignment3.Users.Student>();
                        break;
                    case 0: // Go back
                        // Do nothing
                        break;
                    default:
                        Console.Error.WriteLine("Error: Invalid user type");
                        break;
                }
            }
            if (newUsr != null)
            {
                SIT321_Software_Assignment3.Users.UserManager.Add(newUsr);
                result = new ExtendedResult(ResultCode.None);
            }
            else
            {
                result = new ExtendedResult(ResultCode.Failure);
            }
        }

        private static void FindUserHandler(User usr, out ExtendedResult result)
        {
            Console.Write("Enter login name: ");
            string login = Console.ReadLine();

            User searchUser;
            if ((searchUser = SIT321_Software_Assignment3.Users.UserManager.Find(login)) == null)
            {
                Console.Error.WriteLine("Error: User not found");
                result = new ExtendedResult(ResultCode.Failure);
            }
            else
            {
                Console.WriteLine(searchUser.GetDetail());
                Console.WriteLine();
                result = new ExtendedResult(ResultCode.None);
            }
        }

        private static void SearchUserHandler(User usr, out ExtendedResult result)
        {
            string searchText = "";

            while(searchText == "")
            {
                Console.Write("Enter search string: ");
                searchText = Console.ReadLine();
            }

            User[] users = UserManager.Search(searchText);
            Console.WriteLine();
            if (users == null)
            {
                Console.WriteLine("No matching users.");
                result = new ExtendedResult(ResultCode.Failure);
            }
            else
            {
                Console.WriteLine("Matched users:");
                foreach (User u in users)
                    Console.WriteLine("\t" + u);
                result = new ExtendedResult(ResultCode.None);
            }
            Console.WriteLine();
        }

        private static void RemoveUserHandler(User usr, out ExtendedResult result)
        {
            Console.Write("Enter login name: ");
            string login = Console.ReadLine();

            if (login == usr.Login)
                throw new SIT321_Software_Assignment3.Exceptions.DeleteCurrentUserException();

            SIT321_Software_Assignment3.Users.UserManager.Delete(login);
            result = new ExtendedResult(ResultCode.None);
        }
        #endregion
        #region User Management Menu
        public static void UserManagementMenu(User usr, out ExtendedResult result)
        {
            List<MenuOption> menu = new List<MenuOption>();

            menu.Add(new MenuOption("A", "Add new user", AddUserHandler));
            menu.Add(new MenuOption("F", "Find a user", FindUserHandler));
            menu.Add(new MenuOption("S", "Search for a user", SearchUserHandler));
            menu.Add(new MenuOption("R", "Remove a user", RemoveUserHandler));
            menu.Add(new MenuOption("X", "Exit", LogoutHandler));

            result = new ExtendedResult(ResultCode.SubMenu, menu);
        }
        #endregion
        #region Administrator Main Menu
        private static List<MenuOption> GetAdminMenu()
        {
            List<MenuOption> ret = new List<MenuOption>();

            ret.Add(new MenuOption("U", "User Management", UserManagementMenu));

            return ret;
        }
        #endregion
        #region Lecturer Main Menu
        private static List<MenuOption> GetLecturerMenu()
        {
            List<MenuOption> ret = new List<MenuOption>();

            ret.Add(new MenuOption("U", "User Management", UserManagementMenu));

            return ret;
        }
        #endregion
        #region Student Main Menu
        private static List<MenuOption> GetStudentMenu()
        {
            List<MenuOption> ret = new List<MenuOption>();

            ret.Add(new MenuOption("U", "User Management", UserManagementMenu));

            return ret;
        }
        #endregion

        #region Default Main Menu
        public static List<MenuOption> GetMenu(User u)
        {
            List<MenuOption> ret;

            if (u is SIT321_Software_Assignment3.Users.Admin)
                ret = GetAdminMenu();
            else if (u is SIT321_Software_Assignment3.Users.Lecturer)
                ret = GetLecturerMenu();
            else if (u is SIT321_Software_Assignment3.Users.Student)
                ret = GetStudentMenu();
            else
                ret = new List<MenuOption>();


            ret.Add(new MenuOption("X", "Logout", LogoutHandler));

            return ret;
        }
        #endregion
    }
}
