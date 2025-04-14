using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject
{
    class Zero
    {
        public static void Dividing(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }

                double result = a / b;
                Console.Write($"boring, {a} / {b} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.Write("No no no, b is zero, ayayay");
            }
        }
    }
}
