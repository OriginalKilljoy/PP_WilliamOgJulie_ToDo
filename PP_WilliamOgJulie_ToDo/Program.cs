using PP_WilliamOgJulie_ToDo;

List list = new List();

bool isChoosing = true;

while (isChoosing)
{
    Console.WriteLine("[1]See all tasks" +
                      "\n[2]Add task" +
                      "\n[3]Delete task");
    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            Console.Clear();
            list.ShowAllTasks();
            break;
        case "2":
            Console.Clear();
            list.AddTask();
            break;
        case "3":
            Console.Clear();
            list.DeleteTask();
            break;
    }
}