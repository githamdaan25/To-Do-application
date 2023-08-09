using System;
using System.Collections.Generic;

namespace TodoListApp
{
    class Program
    {
        static List<string> todoList = new List<string>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("TODO List App");
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. Mark your Task as Completed");
                Console.WriteLine("3. View your Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the task: ");
                        string task = Console.ReadLine();
                        AddTask(task);
                        break;
                    case "2":
                        Console.Write("Enter the task number to mark as completed: ");
                        int taskNumber = int.Parse(Console.ReadLine());
                        MarkTaskAsCompleted(taskNumber);
                        break;
                    case "3":
                        ViewTasks();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddTask(string task)
        {
            todoList.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        static void MarkTaskAsCompleted(int taskNumber)
        {
            if (taskNumber >= 1 && taskNumber <= todoList.Count)
            {
                todoList[taskNumber - 1] = "[Completed] " + todoList[taskNumber - 1];
                Console.WriteLine("Task marked as completed!");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }

        static void ViewTasks()
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                Console.WriteLine("TODO List:");
                for (int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todoList[i]}");
                }
            }
        }
    }
}
