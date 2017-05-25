using SIT321_Software_Assignment3.Exceptions;
using System;

namespace SIT321_Software_Assignment3.Users
{
    [Serializable]
    public class Admin : User
    {
        public Admin() // required for AutoPrompt
            : base()
        {
        }

        public Admin(string login, string password, string givenName, string familyName)
            : base(login, password, givenName, familyName)
        {
        }

        public override string Title
        {
            get { return "Administrator"; }
        }

        public override string GetDetail()
        {
            return ToString();
        }
    }
}
