using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VectorLib.Lib
{
    public interface IMathVector : IEnumerable
    {
        //public static List<double> Points;
        List<double> Coordinates { get; }
        int Dimensions { get; }

        double this[int i] { get; set; }

        double Length { get; }

        IMathVector SumNumber(double number);

        IMathVector MultiplyNumber(double number);

        IMathVector Sum(IMathVector vector);

        IMathVector Multiply(IMathVector vector);

        double ScalarMultiply(IMathVector vector);

        double CalcDistance(IMathVector vector);
    }
}
