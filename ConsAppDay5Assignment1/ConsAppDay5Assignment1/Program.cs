using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDay5Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[4] { 1, 2, 3, 4 };
            //matrix[1] = new int[2] { 5, 6 };
            //matrix[2] = new int[3] { 7, 8, 9 };
            //Console.WriteLine("Matrix[0][0]: " + matrix[0][0]);
            //Console.WriteLine("Matrix[1][1]: " + matrix[1][1]);

            //foreach (int[] row in matrix)
            //{
            //    foreach (int element in row)
            //    {
            //        Console.Write(element + " ");
            //    }
            //    Console.WriteLine();



            //2nd task
            //int element = matrix[0][1];

            //foreach (int[] row in matrix)
            //{
            //    foreach (int item in row)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //    Console.WriteLine("Value of the second element in the first row (element): " + element);



            //    task3
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[4] { 1, 2, 3, 4 };
            //matrix[1] = new int[3] { 5, 6, 0 };
            //matrix[2] = new int[3] { 7, 8, 9 };
            //matrix[1][2] = 15;


            //foreach (int[] row in matrix)
            //{
            //    foreach (int item in row)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}


            //    task4
            object[][] objectMatrix = new object[2][];
            objectMatrix[0] = new object[] { 42, "Hello", 3.14 };
            objectMatrix[1] = new object[] { true, 'A', DateTime.Now };


            foreach (object[] row in objectMatrix)
            {
                foreach (object item in row)
                {
                    Console.WriteLine($"Type: {item.GetType()}, Value: {item}");
                }

            }
        }
        }
    }

    


