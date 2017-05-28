using SIT321_Software_Assignment3.Exceptions;
using System;

namespace SIT321_Software_Assignment3.Users
{
    [Serializable]
    public class Student : User
    {
       // [AutoPrompt("unit")]
        private string _Unit;
        public string unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        public Student() // required for AutoPrompt
            : base()
        {
        }

        public Student(string login, string password, string givenName, string familyName, string unit)
            : base(login, password, givenName, familyName,unit)
        {
            _Unit = unit;
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
