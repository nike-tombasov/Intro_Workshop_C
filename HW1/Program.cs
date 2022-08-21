int user = 1;

//Task 2
Console.Clear();
user = 1;

Console.WriteLine("Task 2. Return max of 2 numbers");

while (user == 1)
{
    Console.WriteLine("Insert your number 1:");
    int number1_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insert your number 2:");
    int number1_2 = Convert.ToInt32(Console.ReadLine());
    if (number1_1 > number1_2)
    {
        Console.Write(number1_1);
        Console.WriteLine(" is max");
    }
    else
    {
        Console.Write(number1_2);
        Console.WriteLine(" is max");
    }
    Console.WriteLine("Press 1 to repeat task or press 0  for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 4
Console.Clear();
user = 1;

Console.WriteLine("Task 4. Return max of 3 numbers");

while (user == 1)
{
    Console.WriteLine("Insert your number 1:");
    int number2_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insert your number 2:");
    int number2_2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insert your number 3:");
    int number2_3 = Convert.ToInt32(Console.ReadLine());

    if (number2_1 >= number2_2 && number2_1 >= number2_3)
    {
        Console.Write(number2_1);
        Console.WriteLine(" is max");
    }
    else
    {
        if (number2_2 >= number2_3)
        {
            Console.Write(number2_2);
            Console.WriteLine(" is max");
        }
        else
        {
            Console.Write(number2_3);
            Console.WriteLine(" is max");
        }
    }
    Console.WriteLine("Press 1 to repeat task or press 0  for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 6
Console.Clear();
user = 1;

Console.WriteLine("Task 6. Return is number even or not");

while (user == 1)
{
    Console.WriteLine("Insert your number:");
    int number3_1 = Convert.ToInt32(Console.ReadLine());

    if (number3_1 == 0)
    {
        Console.Write(number3_1);
        Console.WriteLine(" is zero");
    }
    else
    {
        if ((number3_1 % 2) == 0)
        {
            Console.Write(number3_1);
            Console.WriteLine(" is even");
        }
        else
        {
            Console.Write(number3_1);
            Console.WriteLine(" is odd");
        }
    }
    Console.WriteLine("Press 1 to repeat task or press 0  for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 8
Console.Clear();
user = 1;

Console.WriteLine("Task 8. Return all even numbers from 1 to inserted");

while (user == 1)
{
    Console.WriteLine("Insert your number:");
    int number4_1 = Convert.ToInt32(Console.ReadLine());

    if (number4_1 <= 1 && number4_1 >= -1 )
    {
        Console.WriteLine("No even numbers");
    }
    else
    {
        if (number4_1 > 1)
        {
            int count = 2;
            while (count <= number4_1)
            {
                Console.WriteLine(count);
                count = count + 2;
            }
        }
        else
        {
            int count = -2;
            while (count >= number4_1)
            {
                Console.WriteLine(count);
                count = count - 2;
            }
        }
    }
    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");