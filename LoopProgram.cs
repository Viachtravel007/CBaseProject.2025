using System;
using System.Text;

namespace LoopLoop
{
    class LoopProgram
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            WorkingHours();
            FibonacciNumbers();
            PasswordCheck();
            CalculationAverage();
            Graphing();
        }

        private static void CalculationAverage()
        {
            Console.Write("Enter the number of employees: ");
            int count = int.Parse(Console.ReadLine());

            string[] firstNames = {
                "Oleksandr", "Andrii", "Dmytro", "Ivan",
                "Taras", "Yurii", "Vasyl", "Petro", "Sofiia",
                "Anna", "Olha", "Kateryna", "Iryna",
                "Nadiia", "Tetiana", "Natalia" };
            string[] lastNames = {
                "Shevchenko", "Melnyk", "Kovalenko", "Boyko",
                "Tkachenko", "Bondarenko", "Kravchenko", "Mazur",
                "Moroz", "Pavlenko", "Lysenko", "Rudenko", "Voitenko",
                "Tymoshenko", "Yurchenko", "Zakharchenko" };

            Random random = new Random();

            double totalSalary = 0;

            for (int i = 1; i <= count; i++)
            {
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                Console.Write($"Enter salary for employee {firstName} {lastName}: ");
                double salary = double.Parse(Console.ReadLine());
                totalSalary += salary;
            }

            double averageSalary = totalSalary / count;
            Console.WriteLine($"Average salary: {averageSalary:F2}");
        }

        private static void Graphing()
        {
            Console.Write("Enter the number of rows: ");
            int numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfRows; i++)
            {
                Thread.Sleep(30);
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            }
            for (int i = numberOfRows - 1; i >= 1; i--)
            {
                Thread.Sleep(30);
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            }
        }

        private static void PasswordCheck()
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool passwordHasSpecial = false;
            bool passwordHasNumber = false;
            bool passwordLong = password.Length >= 8;

            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    passwordHasSpecial = true;
                } else if (Char.IsDigit(c))
                {
                    passwordHasNumber = true;
                }
            }

            if (passwordHasNumber && passwordHasSpecial && passwordLong)
            {
                Console.WriteLine("Password secure");
            } else
            {
                Console.WriteLine("Password dangerous");
            }
        }

        private static void FibonacciNumbers()
        {
            Console.Write("Enter number of Fibonacci numbers: ");
            int Nu = int.Parse(Console.ReadLine());

            if (Nu <= 0)
            {
                Console.WriteLine("enter a number greater than 0");
                return;
            }

            long a = 0, b = 1;

            for (int i = 0; i < Nu; i++)
            {
                Console.Write(a + " ");
                long temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
        }

        private static void WorkingHours()
        {
            Console.Write("Enter number of hours worked today: ");
            double hoursWorked = double.Parse(Console.ReadLine());

            Console.Write("Enter hourly wage: ");
            double hourlyRate = double.Parse(Console.ReadLine());

            double dailyPay = hoursWorked * hourlyRate;

            Console.WriteLine($"Daily pay: ₴{dailyPay}");
        }
    }
}
