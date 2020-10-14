using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VectorLib.Lib.Exceptions;
using VectorLib.Lib.Maths;

namespace VectorLib.Lib
{
    public class MathVector : IMathVector
    {
        private List<double> Points;

        public List<double> Coordinates => Points;

        public MathVector(params double[] args) => Points = new List<double>(args);
        
        public double this[int i] 
        { 
            get
            {
                if (i < this.Points.Count)
                    return Points[i];
                else
                    throw new VectorException("Index out of range");
            }
            set
            {
                if (i < this.Points.Count)
                    Points[i] = value;
                else if (i == this.Points.Count)
                    Points.Add(value);
                else
                    throw new VectorException("Index out of range");
            }
        }

        public int Dimensions => this.Points.Count;

        public double Length => Calculations.VectorLength(this.Points);

        public double CalcDistance(IMathVector vector)
        {
            return Calculations.EuclideanDistance(this.Points, vector.Coordinates);
        }

        public IMathVector MultiplyNumber(double number)
        {
            var points = Calculations.MultiplyVecOnNumber(this.Points, number);

            return new MathVector(points.ToArray());
        }

        public IMathVector Multiply(IMathVector vector)
        {
            var points = Calculations.MultiplOfVecs(this.Points, vector.Coordinates);

            return new MathVector(points.ToArray());
        }

        public double ScalarMultiply(IMathVector vector)
        {
            var result = Calculations.DotProdOfVecs(this.Points, vector.Coordinates);
            return result;
        }

        public IMathVector Sum(IMathVector vector)
        {
            var points = Calculations.SumOfVecs(this.Points, vector.Coordinates);

            return new MathVector(points.ToArray());
        }

        public IMathVector SumNumber(double number)
        {
            var pointsTmp = Calculations.SumOfVecAndNumber(this.Points, number);

            return new MathVector(pointsTmp.ToArray());
        }
         
        public static IMathVector operator +(MathVector vector_1, MathVector vector_2)
        {
            return vector_1.Sum(vector_2);
        }

        public static IMathVector operator +(MathVector vector, double number)
        {
            return vector.SumNumber(number);
        }

        public static double operator *(MathVector vector_1, MathVector vector_2)
        {
            return vector_1.ScalarMultiply(vector_2);
        }

        public static IMathVector operator *(MathVector vector, double number)
        {
            return vector.MultiplyNumber(number);
        }

        public static double operator %(MathVector vector_1, MathVector vector_2)
        {
            return vector_1.ScalarMultiply(vector_2);
        }

        public static IMathVector operator /(MathVector vector_1, MathVector vector_2)
        {
            var points = Calculations.DivOfVecs(vector_1.Coordinates, vector_2.Coordinates);

            return new MathVector(points.ToArray());
        }

        public static IMathVector operator /(MathVector vector, double number)
        {
            return vector.MultiplyNumber(1 / number);
        }

        public static IMathVector operator -(MathVector vector_1, MathVector vector_2)
        {
            var negative_vector = vector_2.MultiplyNumber(-1);

            return vector_1.Sum(negative_vector);
        }

        public static IMathVector operator -(MathVector vector, double number)
        {
            return vector.SumNumber(-1 * number);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Points.GetEnumerator();
        }
    }
}
