using System;
using System.Collections.Generic;
using System.Linq;

namespace SIT321_Software_Assignment3.Exceptions
{
    public class UserExistsException : UserDBException
    {
        private const string DEFAULT_MESSAGE = "User already listed";

        public UserExistsException()
            : this(DEFAULT_MESSAGE)
        {
        }

        public UserExistsException(string message)
            : base(message)
        {
        }

        public UserExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
