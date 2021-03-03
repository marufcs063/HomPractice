using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingExamples
{
    public class EmptyFileException : Exception
    {
        public EmptyFileException(string message)
            : base(message)
        {

        }
    }
}
