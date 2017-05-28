using SIT321_Software_Assignment3.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SIT321_Software_Assignment3.Menus
{
    public static class MenuSystem
    {
        //Need to add more/an option(s) here for student and lecturer. The admin is already there
        //Currently all the users have the same privledges.
  

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
                        MessageBox.Show("Error: Invalid user type");
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
        
        public static void newUser()
        {
            NewUser d = new NewUser();

            d.Show();
        }

        #region Back to main Menu
        public static void loginOpen()
        {
            Form1 d = new Form1();

            d.Show();


        }


        #endregion

        #region Administrator Main Menu
        private static void GetAdminMenu()
        {
            Form2 d = new Form2();

            d.Show();

        }
        #endregion
        #region Lecturer Main Menu
        private static void GetLecturerMenu(User u)
        {

            Form4 d = new Form4();
            
            d.Show();


            d.Welcome(u);
        }
        #endregion
        #region Student Main Menu
        private static void GetStudentMenu(User u)
        {
            Form3 d = new Form3();

            d.Show();

            d.Welcome(u);
        }
        #endregion

        #region Default Main Menu

        public static void GetMe(User u)
        {
            if (u is SIT321_Software_Assignment3.Users.Admin)
                GetAdminMenu();
            else if (u is SIT321_Software_Assignment3.Users.Lecturer)
                GetLecturerMenu(u);
            else if (u is SIT321_Software_Assignment3.Users.Student)
                 GetStudentMenu(u);

        }
        #endregion
    }
}
