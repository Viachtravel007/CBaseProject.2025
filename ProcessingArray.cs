using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject
{
    class ProcessingArray
    {
        static int[,] array = null;
        static Random random = new Random();

        public static void DArrayProcessing()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Create array");
                Console.WriteLine("2. Fill array with random numbers");
                Console.WriteLine("3. Show array");
                Console.WriteLine("4. Sort array");
                Console.WriteLine("0. Exit");

                Console.Write("Your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateArray();
                        break;
                    case "2":
                        FillArray();
                        break;
                    case "3":
                        ShowArray();
                        break;
                    case "4":
                        SortArray();
                        break;
                    case "0":
                        Console.WriteLine("Exiting");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void CreateArray()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            if (rows > 0 && cols > 0)
            {
                array = new int[rows, cols];
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid size input");
            }
        }

        static void FillArray()
        {
            if (array == null)
            {
                Console.WriteLine("Array not created yet");
                return;
            }

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            Console.WriteLine("Success");
        }

        static void SortArray()
        {
            if (array == null)
            {
                Console.WriteLine("Array not created yet");
                return;
            }

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int[] rowArray = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    rowArray[j] = array[i, j];
                }

                Array.Sort(rowArray);

                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rowArray[j];
                }
            }

            Console.WriteLine("Success");
        }

            static void ShowArray()
        {
            if (array == null)
            {
                Console.WriteLine("Array not created yet");
                return;
            }

            Console.WriteLine("Array contents:");
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}
