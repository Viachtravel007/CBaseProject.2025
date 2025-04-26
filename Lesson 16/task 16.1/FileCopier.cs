using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject.Lesson_16.task_16._1
{
    class FileCopier
    {
        public static void CopyPaste()
        {
            try
            {
                Console.Write(@"Enter the path to the first file, source (Like: T:\NotMyComputer\USAMillitarySecret.txt): ");
                string sourcePath = Console.ReadLine();

                Console.Write(@"Enter the path to the secound file, destination (Like: T:\NotMyComputer\CopiedSecret.txt): ");
                string destinationPath = Console.ReadLine();

                if (!File.Exists(sourcePath))
                {
                    Console.WriteLine("File not found");
                    return;
                }

                string content = File.ReadAllText(sourcePath);
                File.WriteAllText(destinationPath, content);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
    }
}
