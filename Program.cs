using System;

namespace DefaultProject
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Enter type operation which you want (+, -, *, / or ^): ");

            string operation = Console.ReadLine();

            double number1, number2;

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
                    Console.WriteLine($"Result: " + (number2 != 0 ? (number1 / number2) : "division by zero is not allowed."));
                    break;

                case "^":
                    (number1, number2) = numberEnter();
                    Console.WriteLine($"Result: {Math.Pow(number1, number2)}");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }

            static (double, double) numberEnter()
            {
                try
                {
                    Console.Write("input first number: ");
                    double number1 = double.Parse(Console.ReadLine());

                    Console.Write("input second number: ");
                    double number2 = double.Parse(Console.ReadLine());

                    return (number1, number2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter valid numbers.");
                }

                return numberEnter();

            }

        }
    }
}