using SIT321_Software_Assignment3.Subsystems;
using System;

namespace SIT321_Software_Assignment3.Users
{
    [Serializable]
    public abstract class User
    {
        [AutoPrompt("login name")]
        private string _Login;
        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        [AutoPrompt("password")]
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        [AutoPrompt("given name")]
        private string _GivenName;
        public string GivenName
        {
            get { return _GivenName; }
            set { _GivenName = value; }
        }

        [AutoPrompt("family name")]
        private string _FamilyName;
        public string FamilyName
        {
            get { return _FamilyName; }
            set { _FamilyName = value; }
        }



        public abstract string Title { get; }

        public User() // required for AutoPrompt
        {
        }

        public User(string login, string password, string givenName, string familyName)
        {
            _Login = login;
            _Password = password;
            _GivenName = givenName;
            _FamilyName = familyName;
        }

        /*public User(string login, string password, string givenName, string familyName, string unit)
        {
            _Login = login;
            _Password = password;
            _GivenName = givenName;
            _FamilyName = familyName;
        }*/

        public abstract string GetDetail();

        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", _GivenName, _FamilyName, Title);
        }
    }
}
