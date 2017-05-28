using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using SIT321_Software_Assignment3.Exceptions;
using System.Runtime.Serialization.Formatters.Binary;

namespace SIT321_Software_Assignment3.Users
{
    public static class UserManager
    {
        private delegate User UserCreationHandler(string[] elements);

        public static List<User> _UserList = new List<User>();
        public static void Add(User user)
        {
            if (Find(user.Login) != null)
            {
                throw new UserExistsException();
            }
            _UserList.Add(user);
        }

        public static void Delete(string login)
        {
            var u = Find(login);

            if (u == null)
            {
                throw new UserNotFoundException();
            }
            _UserList.Remove(Find(login));
        }

        public static User Find(string login)
        {
            var usr = (from u in _UserList.AsEnumerable()
                       where u.Login == login
                       select u).SingleOrDefault<User>();

            return usr;
        }

        public static User[] Search(string searchString)
        {
            List<User> result = new List<User>();
            searchString = searchString.ToLower();

            foreach (User u in _UserList)
            {
                if (u.Login.ToLower().IndexOf(searchString) > -1 ||
                    u.GivenName.ToLower().IndexOf(searchString) > -1 ||
                    u.FamilyName.ToLower().IndexOf(searchString) > -1)
                    result.Add(u);
            }

            if (result.Count == 0)
                return null;
            else
                return result.ToArray();
        }

        public static void LoadDB(string fileName)
        {
            try
            {
                using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    _UserList = (List<User>)bf.Deserialize(fs);
                    fs.Close();
                }
            }
            catch (Exception e)
            {

            }
        }

        public static List<User> getusers()
        {
            _UserList = new List<User>();
            _UserList.Add(new Admin("admin", "admin", "Admin", "User"));
            _UserList.Add(new Student("dastro", "pass", "Dave", "Astro"));
            _UserList.Add(new Student("hgall", "pass", "Hayden", "Gallop"));
            _UserList.Add(new Lecturer("ewill", "pass", "Emily", "Williams", "SIT325"));

            return _UserList;
        }

        public static void SeedDB()
        {
            _UserList = new List<User>();
            _UserList.Add(new Admin("admin", "admin", "Admin", "User"));
            _UserList.Add(new Student("dastro", "pass", "Dave", "Astro"));
            _UserList.Add(new Student("hgall", "pass", "Hayden", "Gallop"));
            _UserList.Add(new Lecturer("ewill", "pass", "Emily", "Williams", "SIT325"));

            List<string> stringUserList = new List<string>();
            stringUserList.Add("ABCLDSKJFLKD");
            stringUserList.Add("AdfBCLDSKJFLKD");
            stringUserList.Add("ABCLDdafdsfSKJFLKD");



            foreach (string u in stringUserList)
            {
             //   Form2.dataGridView1 d = new Form2.dataGridView1();

            }
        }


        public static void SaveDB(string fileName)
        {
            try
            {
                using (FileStream fs = File.Open(fileName, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, _UserList);
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                throw new UserDBIOException(UserDBIOException.DEFAULT_WRITE_MESSAGE, e);
            }
        }

        public static User ValidateLogin(string login, string password)
        {
            var u = Find(login);

            if (u != null && u.Password != password)
            {
                throw new InvalidLoginException();
            }
            return u;
        }
    }
}
