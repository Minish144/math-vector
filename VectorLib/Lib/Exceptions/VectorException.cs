using System;
using System.Collections.Generic;
using System.Text;

namespace VectorLib.Lib.Exceptions
{
    class VectorException : Exception
    {
        public VectorException(string message) : base(message)
        { }
    }
}
