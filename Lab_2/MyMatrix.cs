using System;

namespace Lab_2
{
    public class MyMatrix
    {
        private double[,] _matrix;

        public int Height
        {
            get => this._matrix.GetLength(0);
        }

        public int Width
        {
            get => this._matrix.GetLength(1);
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
        }

        public MyMatrix(MyMatrix inputMatrix)
        {
            this._matrix = inputMatrix._matrix;
        }

        public MyMatrix(double[,] inputMatrix)
        {
            this._matrix = inputMatrix;
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
                this._matrix = new double[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        this._matrix[i, j] = inputDoubles[i][j];
                    }
                }
            }
            catch
            {
                Console.WriteLine("Matrix is not a quad");
            }
        }

        public MyMatrix(String[] text)
        {
            int size = text[0].Split(' ').Length;
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (size != text[i].Split(' ').Length)
                        throw new Exception("Matrix has a different number of elements");
                }
                _matrix = new double[text.Length, size];
                for (int i = 0; i < Height; i++)
                {
                    String[] numbers = text[i].Split(' ');
                    for (int j = 0; j < Width; j++)
                        this._matrix[i, j] = Convert.ToDouble(numbers[j]);
                }
            }
            catch
            {
                Console.WriteLine("Matrix has a different number of elements");
            }
        }

        public MyMatrix(String inputString):this(inputString.Split('\t'))
        {
        }

        public double this[int x, int y]
        {
            get { return _matrix[x, y]; }
            set { this._matrix[x, y] = value; }
        }

        public double GetElement(int i, int j)
        {
            return this._matrix[i, j];
        }

        public void SetElement(int i, int j, double num)
        {
            this._matrix[i, j] = num;
        }

        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            double[,] result = new double[matrix1.Height, matrix2.Width];
            try
            {
                if (matrix1.Width != matrix2.Height) throw new Exception("Matrix1 Width not equals Matrix2 Height");

                for (int i = 0; i < matrix1.Height; i++)
                {
                    for (int j = 0; j < matrix2.Width; j++)
                    {
                        result[i, j] = 0;
                        for (int k = 0; k < matrix1.Width; k++)
                        {
                            result[i, j] += matrix1[i, k] * matrix2[k, j];
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

        protected double[,] GetTransponedArray()
        {
            double[,] result = new double[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    result[i, j] = this._matrix[j, i];
                }
            }

            return result;
        }

        public MyMatrix GetTransponedCopy()
        {
            return new MyMatrix(this.GetTransponedArray());
        }

        public void TransopnedMe()
        {
            this._matrix = GetTransponedArray();
        }

        override public String ToString()
        {
            String msg = "";
            if (this._matrix == null) return "Matrix is null";
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    msg += this._matrix[i, j] + "\t";
                }

                msg += "\n";
            }

            return msg;
        }
    }
}