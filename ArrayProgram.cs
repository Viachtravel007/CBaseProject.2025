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

        }
    }
}
