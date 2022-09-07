int user = 0;

//Task 41
Console.Clear();
user = 1;

Console.WriteLine("Task 41. Count every positive inserted number");

while (user == 1)
{
    Console.WriteLine("How many numbers will be inserted?");
    int nums41 = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 1; i <= nums41; i++)
    {
        Console.Write($"Enter number {i}: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) count++;
    }
    Console.WriteLine("Total positive numbers - " + count);

    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 43
Console.Clear();
user = 1;

Console.WriteLine("Task 43. Find an intersection point of two lines, " +
"using equation y = k1 * x + b1 and y = k2 * x + b2");

while (user == 1)
{
    Console.WriteLine("Enter variables: ");
    Console.Write("b1 - ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k1 - ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 - ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2 - ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    if (k1 - k2 == 0) Console.WriteLine("No solution");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Intersection point - ({x}; {y})");
    }
    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");