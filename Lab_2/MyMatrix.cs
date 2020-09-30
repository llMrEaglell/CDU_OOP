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

        public static MyMatrix operator * (MyMatrix matrix1, MyMatrix matrix2)
        {
            // TODO Перевірка чи можливо перемножити

            double[,] result = new double[matrix1.Height,matrix2.Width];

            return new MyMatrix(result);
        }

        override public String ToString()
        {
            return "";
        }
    }
}