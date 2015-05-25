//Program reads in 2 sparse matrices from txt files
//Store them as linked list
//Perform Addition of 2 matrices
//Store result in a linked list
//Display all 3 matrices
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuGeneric;
using System.IO;

namespace PracticeTasks
{
    public class MatrixOperation
    {
        public static void MatrixOperationGo()
        {
            var matrix1 = new Matrix("matrix1.txt");
            var matrix2 = new Matrix("matrix2.txt");

            var matrix3 = Matrix.AddMatrix(matrix1, matrix2);
            matrix1.WriteMatrix("Matrix 1: ");
            matrix2.WriteMatrix("Matrix 2: ");
            matrix3.WriteMatrix("Matrix Result: ");
        }
    }

    public class MatrixNode
    {
        int _value;
        int _row;
        int _col;

        /// <summary>
        /// MatrixNode constructor
        /// </summary>
        /// <param name="value">Matrix node value</param>
        /// <param name="row">Matrix node x coordinate</param>
        /// <param name="col">Matrix node y coordinate</param>
        public MatrixNode(int value, int row, int col)
        {
            _value = value;
            _row = row;
            _col = col;
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }

        public int Row
        {
            get
            {
                return _row;
            }
        }

        public int Col
        {
            get
            {
                return _col;
            }
        }

        /// <summary>
        /// Overriden ToString() from the System.Object
        /// Return a string with only the value of the matrix node
        /// But not its coordinate
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _value.ToString();
        }
    }

    public class Matrix
    {
        LList<MatrixNode> _list;
        int _matrixSize;

        /// <summary>
        /// Matrix Constructor
        /// Takes a size parameter and establish a new empty LList
        /// </summary>
        /// <param name="size"></param>
        public Matrix(int size)
        {
            _matrixSize = size;
            _list = new LList<MatrixNode>();
        }

        /// <summary>
        /// Matrix Constructor
        /// Takes a fileName parameter
        /// Read and assign size from the file
        /// Add nodes into new established LList base on the file content
        /// </summary>
        /// <param name="fileName"></param>
        public Matrix(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            //read in first line to get size of matrix
            string[] temp = file.ReadLine().Split(' ');
            _matrixSize = Convert.ToInt32(temp[0]);

            _list = new LList<MatrixNode>();
            //interate through each line
            //add a matrixNode if the value is not zero
            int row = 0;
            int value = 0;
            while (file.Peek() > 0)
            {
                var temp2 = file.ReadLine().Split(' ');
                for (int i = 0; i < _matrixSize; i++)
                {
                    value = Convert.ToInt32(temp2[i]);
                    if (value != 0)
                    {
                        AddNode(value, row, i);
                    }
                }
                row++;
            }
        }

        public int Size
        {
            get
            {
                return _matrixSize;
            }
        }

        public LList<MatrixNode> List
        {
            get
            {
                return _list;
            }
        }

        /// <summary>
        /// Overriden ToString() method
        /// Assign all none-zero values of the matrix into one string
        /// use space to split each other
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var current = _list.First;
            string result = "";
            while (current != null)
            {
                result += current.Value.ToString();
                if (current.Next != null)
                    result += " ";
                current = current.Next;
            }
            return result;
        }

        /// <summary>
        /// Add a new node to the matrix list
        /// </summary>
        /// <param name="value"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void AddNode(int value, int row, int col)
        {
            _list.AddLast(new MatrixNode(value, row, col));
        }

        /// <summary>
        /// Print whole matrix by some defined format
        /// </summary>
        /// <param name="header"></param>
        public void WriteMatrix(string header)
        {
            string firstLine = "";
            firstLine += header;
            firstLine += this.ToString();
            Console.WriteLine(firstLine);

            var current = _list.First;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (current.Value.Row == i && current.Value.Col == j)
                    {
                        Console.Write(current.Value.Value);
                        current = current.Next;
                    }
                    else
                    {
                        Console.Write(0);
                    }

                    if (j == 3)
                    {
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }

        }

        /// <summary>
        /// A static method, used to add 2 matrices
        /// It returns a new matrix which represent the addition result of those 2 matrices
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static Matrix AddMatrix(Matrix matrix1, Matrix matrix2)
        {
            //return null if matrix sizes do not match
            if (matrix1.Size != matrix2.Size)
            {
                Console.WriteLine("Cannot perfrom addition on 2 matrices with difference sizes");
                return null;
            }

            //iterate through size*size, once coordinate appears in any of operands
            //and the sum is not zero, add a node in the new matrix with value of this
            //sum and coordinate of this coordinate
            var matrix = new Matrix(matrix1.Size);
            var current1 = matrix1.List.First;
            var current2 = matrix2.List.First;
            int sum = 0;
            for (int i = 0; i < matrix.Size; i++)
            {
                for (int j = 0; j < matrix.Size; j++)
                {
                    sum = 0;
                    if (current1.Value.Row == i && current1.Value.Col == j)
                    {
                        sum += current1.Value.Value;
                        current1 = current1.Next;
                    }
                    if (current2.Value.Row == i && current2.Value.Col == j)
                    {
                        sum += current2.Value.Value;
                        current2 = current2.Next;
                    }
                    if (sum != 0)
                    {
                        matrix.List.AddLast(new MatrixNode(sum, i, j));
                    }
                }
            }

            return matrix;
        }
    }
}
