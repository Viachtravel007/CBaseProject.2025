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
            if (b != 0)
            {
                Console.Write($"boring, {a} / {b} = {a/b}");
            }
            else
            {
                Console.Write("No no no, b is zero, ayayay");
            }
        }
    }
}
