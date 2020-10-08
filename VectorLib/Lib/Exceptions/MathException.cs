using System;
using System.Collections.Generic;
using System.Text;

namespace VectorLib.Lib.Exceptions
{
    class MathException : Exception
    {
        public MathException(string message) : base(message)
        { }
    }
}
