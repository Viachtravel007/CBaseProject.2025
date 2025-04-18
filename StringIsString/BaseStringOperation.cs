using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DefaultProject.StringIsString
{
    class BaseStringOperation
    {
        public static void NameNameCheck()
        {
            Console.Write("Enter your full name (Ex: Anna Miller, Shevchenko Georgy): ");
            string fullName = Console.ReadLine();
            string[] name = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (name.Length != 2)
            {
                Console.WriteLine("Just first name and last name");
                return;
            }


            string firstInitial = name[0].Substring(0, 1);
            string secoundInitial = name[1].Substring(0, 1);

            if (string.Equals(firstInitial, secoundInitial, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("OMG, your first and last name start from the same letter!");
            }
            else
            {
                Console.Write("I think you have a name, so, congratulations?");
            }
        }

        public static void spaceDelete()
        {
            Console.Write("offer sacrifice to the gods of space: ");
            string sacrifice = Console.ReadLine();
            if (!sacrifice.Contains(" "))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                LOOK();
                return;
            }
            StringBuilder stringBuilder = new StringBuilder(sacrifice);
            stringBuilder.Replace(" ", "");
            Console.Write(stringBuilder.ToString());
        }

        private static void LOOK()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Random random = new Random();

            string message = "you want to deceive the gods?";
            string chars = "!@#$%^&*()_+-=<>?/|[]{}abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            for (int i = 0; i < message.Length; i++)
            {
                for (int glitch = 0; glitch < 13; glitch++)
                {
                    char[] destructionMessage = message.ToCharArray();

                    for (int j = i; j < message.Length; j++)
                    {
                        destructionMessage[j] = chars[random.Next(chars.Length)];
                    }

                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(new string(destructionMessage));
                    Thread.Sleep(15);
                }

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(message.Substring(0, i + 1));
                Thread.Sleep(30);
            }

            Console.ResetColor();
        }

        public static void reportGenerator()
        {
            StringBuilder reportBuild = new StringBuilder();

            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            reportBuild.AppendLine($"title: {title}");
            reportBuild.AppendLine($"Date: {DateTime.Now.ToShortDateString()}");
            reportBuild.AppendLine("Events:");

            Console.WriteLine("Enter events (type 'exit' to finish):");

            while (true)
            {
                string eventInput = Console.ReadLine();

                if (string.Equals(eventInput, "exit", StringComparison.OrdinalIgnoreCase))
                    break;

                reportBuild.AppendLine($"- {eventInput}");
            }

            Console.WriteLine("ready report:");
            Console.WriteLine(reportBuild.ToString());
        }
    }
}
