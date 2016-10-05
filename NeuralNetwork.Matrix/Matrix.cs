using System;

namespace NeuralNetwork.Matrix
{
    public class Matrix
    {
        public double This { get; set; } // ici incompréhension this[int row, int col]
        public int Cols { get; set; }
        public int Rows { get; set; }
        public int Size { get; set; }

        public double[] ToPackedArray()
        {
            throw new NotImplementedException();
        }

        public static Matrix CreateColumnMatrix(double[] input)
        {
            throw new NotImplementedException();
        }

        public static Matrix CreateRowMatrix(double[] input)
        {
            throw new NotImplementedException();
        }

        public void Add(int row, int col, double value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public Matrix Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(Matrix matrix)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Matrix matrix, int precision)
        {
            throw new NotImplementedException();
        }

        public int FromPackedArray(double[] array, int index)
        {
            throw new NotImplementedException();
        }

        public Matrix GetCol(int col)
        {
            throw new NotImplementedException();
        }

        public Matrix GetRow(int row)
        {
            throw new NotImplementedException();
        }

        public bool IsVector()
        {
            throw new NotImplementedException();
        }

        public bool IsZero()
        {
            throw new NotImplementedException();
        }

        public void Randomize(double min, double max)
        {
            throw new NotImplementedException();
        }

        public double Sum()
        {
            throw new NotImplementedException();
        }
    }
}
