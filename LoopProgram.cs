using System;

namespace LoopLoop
{
    class LoopProgram
    {
        static void Main()
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
    }
}
