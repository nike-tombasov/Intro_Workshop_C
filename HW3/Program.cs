int user = 0;

//Task 19
Console.Clear();
user = 1;

Console.WriteLine("Task 19. Return if inserted 5-digit number is palindrome");

while (user == 1)
{
    // int num19 = new Random().Next(10000, 100000);
    Console.WriteLine("Insert your 5-digit number:");
    int num19 = Convert.ToInt32(Console.ReadLine());
    string result19 = Convert.ToString(num19);
    Console.Write(num19);
    if (num19 >= 10000 && num19 < 100000)
    {
            if (result19[0] == result19[4] && result19[1] == result19[3])
        {
            Console.WriteLine(" - is palindrome");
        }
        else
        {
            Console.WriteLine(" - is not palindrome");
        }
    }
    else
    {
         Console.WriteLine(" - is not 5-digit number!!! Try again harder");
    }
    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 21
Console.Clear();
user = 1;

Console.WriteLine("Task 21. Return distance between two 3D points");

while (user == 1)
{
    int num21x1 = new Random().Next(-100, 100);
    int num21x2 = new Random().Next(-100, 100);
    int num21y1 = new Random().Next(-100, 100);
    int num21y2 = new Random().Next(-100, 100);
    int num21z1 = new Random().Next(-100, 100);
    int num21z2 = new Random().Next(-100, 100);

    Console.WriteLine($"Point 1: ({num21x1}, {num21y1}, {num21z1})");
    Console.WriteLine($"Point 2: ({num21x2}, {num21y2}, {num21z2})");

    double xyz = Math.Sqrt(Math.Pow((num21x2-num21x1), 2) 
    + Math.Pow((num21y2 - num21y1), 2) 
    + Math.Pow((num21z2 - num21z1), 2));
    
    Console.WriteLine($"Distance between 1-2 points: {Math.Round(xyz, 2)}");
    
    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 23
Console.Clear();
user = 1;

Console.WriteLine("Task 23. Return sheet of cubed numbers from 1 to N");

while (user == 1)
{
    int num23 = new Random().Next(1, 50);
    Console.WriteLine($"N is {num23}");

    for (int count23 = 1; count23 <= num23; count23++)
    {
        Console.WriteLine($"{count23}) {Math.Pow(count23, 3)}");
    }

        Console.WriteLine("Press 1 to repeat task or press 0 for next task");
        user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");