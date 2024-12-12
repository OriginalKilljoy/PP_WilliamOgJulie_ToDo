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
            foreach (var task in toDoList)
            {
                Console.WriteLine(task.Name);
            }
            Console.WriteLine();
            Thread.Sleep(700);
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

        }

    }
}
