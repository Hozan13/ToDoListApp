using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    public class Program
    {
        static void AddTask()
        {
            Console.WriteLine("Enter the task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        static List<string> tasks = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("To-Do List Application");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddTask();
                }
                else if (choice == "2")
                {
                    ListTasks();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        static void ListTasks()
        {
            Console.WriteLine("Your tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No task available.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
    }
}
