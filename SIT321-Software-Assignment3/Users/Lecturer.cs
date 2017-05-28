using SIT321_Software_Assignment3.Exceptions;
using SIT321_Software_Assignment3.Subsystems;
using System;
using System.Text;

namespace SIT321_Software_Assignment3.Users
{
    [Serializable]
    public class Lecturer : User
    {
        [AutoPrompt("unit")]
        private string _Unit;
        public string unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        public Lecturer() // required for AutoPrompt
            : base()
        {
        }

        public Lecturer(string login, string password, string givenName, string familyName, string unit)
            : base(login, password, givenName, familyName)
        {
        }

        public override string Title
        {
            get { return "Lecturer"; }
        }

        public override string GetDetail()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(ToString());
            sb.AppendLine(string.Format("\tUnit: {0}", _Unit));
    
            return sb.ToString();
        }
    }
}
