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
            double result = 0;

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
                    if (number2 != 0)
                        Console.WriteLine($"Result: {number1 / number2}");
                    else
                    {
                        Random random = new Random();
                        int events = random.Next(1, 4);
                        switch (events) 
                        {
                            case 1:
                                string[] lines = {
                            "C:\\Windows\\System32> del *.*",
                            "",
                            "C:\\Windows\\System32> Deleting file: kernel32.dll",
                            "C:\\Windows\\System32> Deleting file: user32.dll",
                            "C:\\Windows\\System32> Deleting file: ntdll.dll",
                            "C:\\Windows\\System32> Deleting file: advapi32.dll",
                            "C:\\Windows\\System32> Deleting file: gdi32.dll",
                            "C:\\Windows\\System32> Deleting file: shell32.dll",
                            "C:\\Windows\\System32> Deleting file: cmd.exe",
                            "C:\\Windows\\System32> Deleting file: winlogon.exe",
                            "C:\\Windows\\System32> Deleting file: services.exe",
                            "C:\\Windows\\System32> Deleting file: svchost.exe",
                            "C:\\Windows\\System32> Deleting file: spoolsv.exe",
                            "C:\\Windows\\System32> Deleting file: msconfig.exe",
                            "C:\\Windows\\System32> Deleting file: regedit.exe",
                            "C:\\Windows\\System32> Deleting file: lsass.exe",
                            "C:\\Windows\\System32> Deleting file: taskmgr.exe",
                            "C:\\Windows\\System32> Deleting file: explorer.exe",
                            "C:\\Windows\\System32> Deleting file: wininit.exe",
                            "",
                            "C:\\Windows\\System32> All files deleted successfully.",
                            "",
                            "C:\\Windows\\System32> The system will now shut down to prevent further damage."
                            };

                                foreach (string line in lines)
                                {
                                    Console.WriteLine(line);
                                    Thread.Sleep(random.Next(100, 666));
                                }
                                break;

                            case 2:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Divide by zero? The smartest one?");
                                Console.ResetColor();
                                break;

                            case 3:

                                Console.WriteLine($"Your data has been transmitted to the SBU. " +
                                    $"\nYour detention will be handled by the 107th Reactive Artillery Brigade of Kremenchuk. " +
                                    $"\nPlease step closer to the window");
                                break;
                        }
                        
                    }
                    break;

                case "^":
                    Console.Write("Input base number: ");
                    number1 = double.Parse(Console.ReadLine());
                    Console.Write("Input exponent: ");
                    number2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {Math.Pow(number1, number2)}");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }

            static (double, double) numberEnter()
            {
                Console.Write("input first number: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.Write("input second number: ");
                double number2 = double.Parse(Console.ReadLine());

                return (number1, number2);
            }

        }
    }
}