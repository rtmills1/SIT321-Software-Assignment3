using SIT321_Software_Assignment3.Exceptions;
using System;

namespace SIT321_Software_Assignment3.Users
{
    [Serializable]
    public class Student : User
    {
        public Student() // required for AutoPrompt
            : base()
        {
        }

        public Student(string login, string password, string givenName, string familyName)
            : base(login, password, givenName, familyName)
        {
        }

        public override string Title
        {
            get { return "Student"; }
        }

        public override string GetDetail()
        {
            return ToString();
        }
    }
}
