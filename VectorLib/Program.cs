using System;
using VectorLib.Lib;

namespace VectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            MathVector vec = new MathVector(1, 2, 3);
            MathVector vec2 = (MathVector)vec.MultipleNumber(5);

            var vec3 = vec + vec2;
            foreach (var a in vec3)
                Console.WriteLine(a);
        }
    }
}
