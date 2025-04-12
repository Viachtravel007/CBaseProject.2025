using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject
{
    class ArrayProgram
    {
        public static void ArrayEnter()
        {

            Random random = new Random();

            int[] randomArray = new int[10];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(-10, 11);
                if (i % 2 == 0)
                {
                    Console.Write(randomArray[i] + " ");
                }
            }
            Console.WriteLine();

            int sum = 0;
            foreach (int num in randomArray)
            {
                sum = sum + num;
            }
            if (sum > 0)
            {
                Console.WriteLine("array sum more than 0");
            }
            else if (sum < 0)
            {
                Console.WriteLine("array sum less than 0");
            }
            else
            {
                Console.WriteLine("Balance");
            }
            Console.WriteLine("---------------------------------------");

            int[,] multiArray = new int[10, 10];

            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    multiArray[i, j] = (i + 1) * (j + 1);
                    Console.Write($"{multiArray[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------");

            int[][] jaggernautArray = new int[5][];
            jaggernautArray[0] = new int[5];
            jaggernautArray[1] = new int[4];
            jaggernautArray[2] = new int[5];
            jaggernautArray[3] = new int[6];
            jaggernautArray[4] = new int[5];

            for (int i = 0; i < jaggernautArray.Length; i++)
            {
                for (int j = 0; j < jaggernautArray[i].Length; j++)
                {
                    jaggernautArray[i][j] = random.Next(-100, 101);
                    Console.Write($"{jaggernautArray[i][j],4} ");
                }
                Console.WriteLine();
            }

            int minElement = 100;
            int[] indexMin = { 0, 0 };
            int maxElement = -100;
            int[] indexMax = { 0, 0 };
            for (int i = 0; i < jaggernautArray.Length; i++)
            {
                for (int j = 0; j < jaggernautArray[i].Length; j++)
                {
                    if (jaggernautArray[i][j] < minElement)
                    {
                        minElement = jaggernautArray[i][j];
                        indexMin = [i , j];
                    }
                    if (jaggernautArray[i][j] > maxElement)
                    {
                        maxElement = jaggernautArray[i][j];
                        indexMax = [i , j];
                    }
                }
            }
            Console.WriteLine($"{minElement} with index ({indexMin[0]}; {indexMin[1]})");
            Console.WriteLine($"{maxElement} with index ({indexMax[0]}; {indexMax[1]})");
        }
    }
}
