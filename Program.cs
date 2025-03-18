namespace DefaultProject
{
    internal class Program
    {
        static void Main()
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("Enter number from 1 to 7 (days of week): ");

            int input = int.Parse(Console.ReadLine());

            if (input <= 0 || input >= 8)
            {
                Console.WriteLine("Invalid input");
            } else
            {
                Console.WriteLine(weekDays[input - 1]);
            }

        }
    }
}