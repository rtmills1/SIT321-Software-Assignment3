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

        public Admin(string login, string password, string givenName, string familyName, string unit)
            : base(login, password, givenName, familyName, unit)
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
