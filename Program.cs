namespace DefaultProject
{
    internal class Program
    {
        static void Main()
        {
            string[] rainbowColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Cyan", "Magenta" };

            ConsoleColor[] colors = {
            ConsoleColor.Red,
            ConsoleColor.DarkYellow,
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.Cyan,
            ConsoleColor.Magenta
            };

            for (int i = 0; i < rainbowColors.Length; i++)
            {
                Console.ForegroundColor = colors[i];
                Console.WriteLine(rainbowColors[i]);
            }
        }
    }
}