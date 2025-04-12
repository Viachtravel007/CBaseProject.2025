using LoopLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject
{
    class Start
    {
        static void Main()
        {
            ArrayProgram.ArrayEnter();

            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Zero.Dividing(a, b);

            //Program.NoMain();

            //LoopProgram.AgainNoMain();
        }
    }
}
