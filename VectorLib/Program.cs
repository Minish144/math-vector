using System;
using VectorLib.Lib;

namespace VectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            MathVector vec = new MathVector(1, 2, 3);
            MathVector vec2 = (MathVector)vec.MultiplyNumber(5);

            var res = vec.Multiply(vec2);
            Console.WriteLine(res);
        }
    }
}
