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

            if (string.Equals(firstInitial, secoundInitial, StringComparison.OrdinalIgnoreCase)) {
                Console.Write("OMG, your first and last name start from the same letter!");
            }
            else
            {
                Console.Write("I think you have a name, so, congratulations?");
            }
        }
    }
}
