using System;
using System.Collections.Generic;
using System.Linq;

namespace SIT321_Software_Assignment3.Exceptions
{
    public class EasyLibraryException : Exception
    {
        public EasyLibraryException()
            : base()
        {
        }

        public EasyLibraryException(string message)
            : base(message)
        {
        }

        public EasyLibraryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}