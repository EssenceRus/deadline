using Deadline;

List<Tasks> tasks = new List<Tasks>
{
    new Tasks(20,2),
    new Tasks(10,1),
    new Tasks(1,3),
    new Tasks(15,2),
    new Tasks(5,3),
    new Tasks(2,3),
    new Tasks(1,2)
};
var tasksSort = tasks.OrderByDescending(p=>p.Price);
int finalPrice = 0;
int totalTasks = tasks.OrderByDescending(t=>t.Deadline).First().Deadline;
int time = totalTasks-1;

//foreach (var item in tasks.OrderByDescending(c => c.Price))
//{
//    if (time < item.Deadline)
//    {
//        finalPrice += item.Price;
//        Console.WriteLine($"deadline {item.Deadline}  price {item.Price}");
//        totalTasks--;
//    } else
//    {
//        time--;
//    }

//    //if (totalTasks==0)
//    //{
//    //    break;
//    //}
//}
for (int i = 0; i < totalTasks; i++)
{
    foreach (var item in tasksSort)
    {
        if (time < item.Deadline)
        {
            finalPrice += item.Price;
            Console.WriteLine($"deadline {item.Deadline}  price {item.Price}");
            tasks.Remove(item);
            time--;
            break;
        }
    }
}

Console.WriteLine(finalPrice);
