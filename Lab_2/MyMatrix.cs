using System;
using System.Diagnostics;

namespace Lab_2
{
    public class MyMatrix
    {
        private double[,] matrix;

        public int Height
        {
            get { return this.matrix.Length; }
        }
        public int Width
        {
            get { return 0; }
        }

        public MyMatrix(MyMatrix inputMatrix)
        {
            this.matrix = inputMatrix.matrix;
        }

        public MyMatrix(double[,] inputMatrix)
        {
            this.matrix = inputMatrix;
        }

        public MyMatrix(double[][] inputDoubles)
        {
            try
            {
                foreach (double[] arr in inputDoubles)
                {
                    if (inputDoubles.Length != arr.Length) throw new Exception("The number of rows and columns do not match");
                }
                int size = inputDoubles.Length;
                this.matrix = new double[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        this.matrix[i,j] = inputDoubles[i][j];
                    }
                }
            }
            catch 
            {
                Console.WriteLine("Matrix is not a quad");
            }
        }

        
        
    }
}