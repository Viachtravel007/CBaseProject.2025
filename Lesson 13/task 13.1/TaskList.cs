using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProject.Lesson_13.task_13._1

{
    class Tasks
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public Tasks(string title)
        {
            Title = title;
            IsDone = false;
        }
    }
    class TaskList
    {
        static List<Tasks> tasks = new List<Tasks>();

        public static void Menu()
        {

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. add task");
                Console.WriteLine("2. show task list");
                Console.WriteLine("3. mark task as finished");
                Console.WriteLine("4. delete task");
                Console.WriteLine("5. Exit");
                Console.Write("You`re choose: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ShowTasks();
                        break;
                    case "3":
                        MarkTaskDone();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        static void MarkTaskDone()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Task list is empty");
                return;
            }

            Console.Write("Enter task index: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index) && index >= 1 && index <= tasks.Count)
            {
                tasks[index - 1].IsDone = true;
                Console.WriteLine("Congrats, you finish task");
            }
            else
            {
                Console.WriteLine("Task not found");
            }
        }

        static void DeleteTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Task list is empty");
                return;
            }

            Console.Write("Enter task index: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index) && index >= 1 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Task delete");
            }
            else
            {
                Console.WriteLine("Task not found");
            }
        }

        static void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Task list is empty");
                return;
            }

            Console.WriteLine("Task list:"); 

            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsDone ? "[V]" : "[ ]";
                Console.WriteLine($"{i + 1} {status} {tasks[i].Title}");
            }
        }

        static void AddTask()
        {
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("ERROR. Title is empty");
                return;
            }

            tasks.Add(new Tasks(title));
            Console.WriteLine("Task add");
        }

    }
}
