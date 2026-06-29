using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Manager
{
    internal class Program
    {

        class Task
        {
            public string NameOfTask;
            public bool TaskIsComplete;
        }


        static void AddTask(List<Task> tasks)
        {
            Task task = new Task();
            Console.WriteLine("Enter Task");
            task.NameOfTask = Console.ReadLine();
            task.TaskIsComplete = false;
            tasks.Add(task);

        }

        static void ShowTasks(List<Task> tasks)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskIsComplete == false)
                {
                    Console.WriteLine($"{i + 1} {tasks[i].NameOfTask} - [ ]");
                }else
                {
                    Console.WriteLine($"{i + 1} {tasks[i].NameOfTask} - [ X ]");
                }
            }
        }

        static void CompleteTask(List<Task> tasks)
        {
                ShowTasks(tasks);

            int choose = int.Parse(Console.ReadLine());
            int index = choose - 1;
            if (index >= 0 && index < tasks.Count)
            {

                tasks[index].TaskIsComplete = true;
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }
        }

        static void DeleteTask(List<Task> tasks)
        {
            ShowTasks(tasks);
            int choose = int.Parse(Console.ReadLine());
            int index = choose - 1;
            if (index >= 0 && index < tasks.Count)
            {

                tasks.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }
        }

        static void SearchTask(List<Task> tasks)
        {
            string search = Console.ReadLine();
            for (int i = 0; i < tasks.Count; i++)
            {
                if(search == tasks[i].NameOfTask)
                {
                    Console.WriteLine("Found Task");
                    return;
                }

            }
            Console.WriteLine("Not Found");
        }

        static void ShowCompleted(List<Task> tasks)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskIsComplete == true )
                {
                    Console.WriteLine($"{i + 1} {tasks[i].NameOfTask} [ X ]");
                }
            }
        }

        static void ShowUncompleted(List<Task> tasks)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].TaskIsComplete == false)
                {
                    Console.WriteLine($"{i + 1} {tasks[i].NameOfTask} [ ]");
                }
            }
        }

        static void EditTask(List<Task> tasks)
        {
            Console.WriteLine("Which Task You Want To Edit ?");
            ShowTasks(tasks);

            int choose = int.Parse(Console.ReadLine());
            int index = choose - 1;
           

            if (index >= 0 && index < tasks.Count)
            {
                Console.WriteLine("Enter New Task:");
                string change = Console.ReadLine();

                tasks[index].NameOfTask = change;

            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }

            }


        
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            

            while (true)
            {
                Console.WriteLine("===== TO DO MANAGER =====\r\n");
                Console.WriteLine("1. Add Task\r\n");
                Console.WriteLine("2. Show Tasks\r\n");
                Console.WriteLine("3.Complete Task\r\n");
                Console.WriteLine("4. Delete Task\r\n");
                Console.WriteLine("5. Search Task\r\n");
                Console.WriteLine("6. Show Completed\r\n");
                Console.WriteLine("7. Show Uncompleted\r\n");
                Console.WriteLine("8. Edit Task\r\n");
                Console.WriteLine("9. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    AddTask(tasks);
                }
                else if(choice == 2)
                {
                    ShowTasks(tasks);
                }
                else if(choice == 3)
                {
                    CompleteTask(tasks);
                }
                else if (choice == 4)
                {
                    DeleteTask(tasks);
                }
                else if (choice == 5)
                {
                    SearchTask(tasks);
                }
                else if (choice == 6)
                {
                    ShowCompleted(tasks);
                }
                else if (choice == 7)
                {
                    ShowUncompleted(tasks);
                }
                else if (choice == 8)
                {
                    EditTask(tasks);
                }
                else if (choice == 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Choice");
                }
            }
        }
    }
}
