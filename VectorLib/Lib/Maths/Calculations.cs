using System;
using System.Collections.Generic;
using System.Text;
using VectorLib.Lib.Exceptions;

namespace VectorLib.Lib.Maths
{
    public static class Calculations
    {
        public static double VectorLength(List<double> points)
        {
            double sum = 0;
            foreach(double point in points)
            {
                sum += Math.Pow(point, 2);
            }

            return Math.Sqrt(sum);
        }

        public static double EuclideanDistance(List<double> points_1, List<double> points_2)
        {
            if (points_1.Count != points_2.Count)
                throw new MathException("Failed to calculate the distance");

            double sum = 0;
            for (int i = 0; i < points_1.Count; i++)
            {
                sum += Math.Pow(points_1[i] - points_2[i], 2);
            }

            return Math.Sqrt(sum);
        }

        public static List<double> MultiplyVecOnNumber(List<double> points, double number)
        {
            List<double> points_new = new List<double>();

            foreach(double point in points)
                points_new.Add(point * number);

            return points_new;
        }

        public static List<double> SumOfVecAndNumber(List<double> points, double number)
        {
            List<double> points_new = new List<double>();

            foreach (double point in points)
                points_new.Add(point + number);

            return points_new;
        }

        public static double DotProdOfVecs(List<double> points_1, List<double> points_2)
        {
            if (points_1.Count != points_2.Count)
                throw new MathException("Failed to calculate the dot product of vectors");

            double sum = 0;
            for (int i = 0; i < points_1.Count; i++)
                sum += points_1[i] * points_2[i];

            return sum;
        }

        public static List<double> SumOfVecs(List<double> points_1, List<double> points_2)
        {
            if (points_1.Count != points_2.Count)
                throw new MathException("Failed to calculate the dot product of vectors");

            List<double> coordinates = new List<double>();
            for (int i = 0; i < points_1.Count; i++)
            {
                coordinates.Add(points_1[i] + points_2[i]);
            }

            return coordinates;

        }
    }
}
