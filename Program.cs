using System.Threading.Tasks;

namespace DefaultProject
{
    internal class Program
    {
        static void Main()
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            string[][] tasks = new string[][]
        {
            new string[] { "Take my son to basketball", "Don't forget to wish Sullivan a happy birthday." },
            new string[] { "Go to the mall for winter clothes", "Massage at 17:30" },
            new string[] { "Fix the power outlet", "Parent-teacher meeting for my daughter" },
            new string[] { "Pick up the bike from Georg", "Evening online conference" },
            new string[] { "Buy food for the celebration", "Take a walk with the kids in the park." },
            new string[] { "Son's birthday", "Pick up my mother from the train station" },
            new string[] { }
        };

            Console.Write("Enter number from 1 to 7 (days of week): ");

            int input = int.Parse(Console.ReadLine());

            if (input > 0 && input < 8)
            {
                int index = input - 1;
                Console.WriteLine($"Day: {weekDays[index]}");
                if (tasks[index].Length > 0)
                {
                    Console.WriteLine("Tasks:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (string element in tasks[index])
                    {
                        Console.WriteLine($"- {element}");
                    }
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Today just chill");
                    Console.ResetColor();
                }
            } 
            else
            {
                Console.WriteLine("Invalid input number");
            }

        }
    }
}