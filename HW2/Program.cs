int user = 0;

// Task 10
Console.Clear();
user = 1;

Console.WriteLine("Return second digit from 3-digit number");

while (user == 1)
{
    int num10 = new Random().Next(100, 1000);
    int result10 = ((num10 % 100) / 10);

    Console.WriteLine($"Second digit from {num10} is {result10}");

    Console.WriteLine("Press 1 to repeat task or press 0  for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


// Task 13
Console.Clear();
user = 1;

Console.WriteLine("Return third digit from 3-digit number or notificate if number is not 3-digit");

while (user == 1)
{
    int num13 = new Random().Next(0, 2000);

    if (num13 >= 100)
    {
        string result13 = Convert.ToString(num13);
        Console.WriteLine($"Third digit in {num13} is {result13[2]}");
    }
    else 
    {
        Console.WriteLine($"No third digit in {num13}");
    }
    
    Console.WriteLine("Press 1 to repeat task or press 0  for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

// Task 15
Console.Clear();
user = 1;

Console.WriteLine("Return if number of day is weekend");

while (user == 1)
{
    int num15 = new Random().Next(1, 8);
    if (num15 > 5)
    {
        Console.WriteLine($"Day {num15} is weekend");
    }
    else
    {
        Console.WriteLine($"Day {num15} is weekday");
    }
    Console.WriteLine("Press 1 to repeat task or press 0  for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");