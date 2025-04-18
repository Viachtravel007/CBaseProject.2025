using System;
using System.Collections.Generic;
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
            string list = ("egg, milk, sugar, cookies");
            StringBuilder stringBuilder = new StringBuilder(list);
            stringBuilder.Replace(" ", "");
            Console.Write(stringBuilder.ToString());
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
