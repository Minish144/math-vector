using System;
using VectorLib.Lib;

namespace VectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            MathVector vec = new MathVector(1, 2, 3);
            //MathVector vec2 = (MathVector)vec.MultipleNumber(5);
            //foreach (double v in vec.Coordinates)
            //    Console.WriteLine(v);
            //foreach (double v in vec2.Coordinates)
            //    Console.WriteLine(v);
            foreach (var v in vec)
                Console.WriteLine(v);
        }
    }
}
