using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIT321_Software_Assignment3.Exceptions
{
    class UserDBIOException : UserDBException
    {
        private const string DEFAULT_MESSAGE = "Error reading from/writing to DB file";
        public const string DEFAULT_READ_MESSAGE = "Error reading from DB file";
        public const string DEFAULT_WRITE_MESSAGE = "Error writing to DB file";

        public UserDBIOException()
            : this(DEFAULT_MESSAGE)
        {
        }

        public UserDBIOException(string message)
            : base(message)
        {
        }

        public UserDBIOException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
