using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject
{
    static class Fibonacci
    {
        public static int whichFibonacci(int number)
        {
            if (number <= 0 || number > 47)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"the developer is so poor that he cannot optimize the method for the number {number}");
            }
            if (number == 1) 
            {
                return 0;
            }
            if (number == 2)
            {
                return 1;
            }
            return whichFibonacci(number - 1) + whichFibonacci(number - 2);
        }
    }
}
