using System.Collections.Generic;
using System.Threading.Tasks;

namespace DefaultProject
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Enter type operation which you want (+, -, *, / or ^): ");

            string operation = Console.ReadLine();

            double number1, number2;
            double result = 0;

            switch (operation)
            {
                case "-":
                    (number1, number2) = numberEnter();
                    Console.WriteLine($"Result: {number1 - number2}");
                    break;

                case "+":
                    (number1, number2) = numberEnter();
                    Console.WriteLine($"Result: {number1 + number2}");
                    break;

                case "*":
                    (number1, number2) = numberEnter();
                    Console.WriteLine($"Result: {number1 * number2}");
                    break;

                case "/":
                    (number1, number2) = numberEnter();
                    if (number2 != 0)
                        Console.WriteLine($"Result: {number1 / number2}");
                    else
                    {
                        Console.WriteLine("Error: Division by zero");
                    }
                    break;

                case "^":
                    Console.Write("Input base number: ");
                    number1 = double.Parse(Console.ReadLine());
                    Console.Write("Input exponent: ");
                    number2 = double.Parse(Console.ReadLine());
                    result = Math.Pow(number1, number2);
                    Console.WriteLine($"Result: {Math.Pow(number1, number2)}");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }

            static (double, double) numberEnter()
            {
                Console.Write("input first number: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.Write("input second number: ");
                double number2 = double.Parse(Console.ReadLine());

                return (number1, number2);
            }

        }
    }
}