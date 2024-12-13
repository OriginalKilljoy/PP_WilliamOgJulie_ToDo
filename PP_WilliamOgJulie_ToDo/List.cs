using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_WilliamOgJulie_ToDo
{
    internal class List
    {
        public List<Task> toDoList = new List<Task>()
        {
            new Task("Do laundry", "Be careful because I have a lot of wool", "13.12.24"),
            new Task("Do the dishes", "They really need to be done asap because I have no plates left", "14.12.24")
        };

        public void ShowAllTasks()
        {
            Console.WriteLine("To do list:");
            ShowTaskNames();
            Console.WriteLine();
            Thread.Sleep(700);
            Console.WriteLine("Enter tasknumber to see info: ");
            var input = Convert.ToInt32(Console.ReadLine()) - 1;
            ShowTaskInfo(input);


        }

        public void AddTask()
        {
            Console.Write("Task name: ");
            var inputName = Console.ReadLine();
            Console.Write("Description: ");
            var inputDescrition = Console.ReadLine();
            Console.Write("Do date: ");
            var inputDate = Console.ReadLine();
            toDoList.Add(new Task(inputName, inputDescrition, inputDate));
            Console.WriteLine();
            Thread.Sleep(700);
        }

        public void DeleteTask()
        {
            ShowTaskNames();
            Console.WriteLine("Enter tasknumber to remove it: ");
            var input = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"You removed {toDoList[input].Name}");
            toDoList.RemoveAt(input);
            Console.ReadKey();
        }

        public void ShowTaskInfo(int input)
        {
            Console.Clear();
            Console.WriteLine(
                $"Task: {toDoList[input].Name}\n" +
                $"Info: {toDoList[input].Description}\n" +
                $"Date: {toDoList[input].DoDate}\n");
            Console.Write("Press ENTER to continue: ");
            Console.ReadKey();
        }

        public void ShowTaskNames()
        {
            int taskNumber = 1;
            foreach (var task in toDoList)
            {
                Console.WriteLine($"[{taskNumber++}] {task.Name}");
            }
        }

    }
}
