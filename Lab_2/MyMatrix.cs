using System;
using System.Diagnostics;

namespace Lab_2
{
    public class MyMatrix
    {
        private double[,] matrix;

        public int Height
        {
            get => this.matrix.GetLength(0);
        }

        public int Width
        {
            get => this.matrix.GetLength(1);
        }

        public int getHeight()
        {
            return Height;
        }

        public int getWidth()
        {
            return Width;
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
                    if (inputDoubles.Length != arr.Length)
                        throw new Exception("The number of rows and columns do not match");
                }

                int size = inputDoubles.Length;
                this.matrix = new double[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        this.matrix[i, j] = inputDoubles[i][j];
                    }
                }
            }
            catch
            {
                Console.WriteLine("Matrix is not a quad");
            }
        }

        // TODO Конструктор з масиву рядків

        public double this[int x, int y] // Індексатор, для зверення як до масиву
        {
            get { return matrix[x, y]; }
            set { this.matrix[x, y] = value; }
        }

        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            double[,] result = new double[matrix1.Height, matrix2.Width];
            try
            {
                if(matrix1.Width != matrix2.Height) throw new Exception("Matrix1 Width not equals Matrix2 Height");

                for (int i = 0; i < matrix1.Height; i++)
                {
                    for (int j = 0; j < matrix2.Width; j++)
                    {
                        result[i, j] = 0;
                        for (int k = 0; k < matrix1.Width; k++)
                        {
                            result[i, j] += matrix1[i, k] * matrix2[k,j];
                        }
                    }
                }
                return new MyMatrix(result);
            }
            catch
            {
                Console.WriteLine("Matrix can't multiply");
            }

            return new MyMatrix(result);
        }

        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            double[,] result = new double[matrix1.Height, matrix2.Width];
            try
            {
                if (matrix1.Height != matrix2.Height && matrix1.Width != matrix2.Width)
                {
                    throw new Exception("Matrix1 Height or Width not equals Matrix2 Height or Width");
                }
                for (int i = 0; i < matrix1.Height; i++)
                {
                    for (int j = 0; j < matrix2.Width; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
                return new MyMatrix(result);
            }
            catch
            {
                Console.WriteLine("Matrix can't append");
            }

            return new MyMatrix(result);
        }

        override public String ToString()
        {
            String msg = "";
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    msg += this.matrix[i, j] + "\t";
                }

                msg += "\n";
            }

            return msg;
        }
    }
}