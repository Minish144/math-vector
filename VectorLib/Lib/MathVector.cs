using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VectorLib.Lib.Exceptions;
using VectorLib.Lib.Maths;

namespace VectorLib.Lib
{
    class MathVector : IMathVector
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

        public IMathVector MultipleNumber(double number)
        {
            var pointsTmp = Calculations.MultiplyVecOnNumber(this.Points, number);

            return new MathVector(pointsTmp.ToArray());
        }

        public double Multiply(IMathVector vector)
        {
            var multiplyResult = Calculations.DotProdOfVecs(this.Points, vector.Coordinates);

            return multiplyResult;
        }

        public IMathVector Sum(IMathVector vector) ///////////////
        {
            var points = Calculations.SumOfVecs(this.Points, vector.Coordinates);

            return new MathVector(points.ToArray());
        }

        public IMathVector SumNumber(double number)
        {
            var pointsTmp = Calculations.SumOfVecAndNumber(this.Points, number);

            return new MathVector(pointsTmp.ToArray());
        }

        IEnumerator IEnumerable.GetEnumerator() ///////////////
        {
            throw new NotImplementedException();
        }
    }
}
