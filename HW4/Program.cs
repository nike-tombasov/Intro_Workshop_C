int user = 0;

//Task 25
Console.Clear();
user = 1;

Console.WriteLine("Task 25. Return raised 1st number to the power of 2nd number");

while (user == 1)
{
    int a25 = new Random().Next(1, 5);
    int b25 = new Random().Next(0, 10);
    Console.WriteLine("1st number - " + a25);
    Console.WriteLine("2nd number - " + b25);

    pow2numbers(a25, b25);

    void pow2numbers(int num1, int num2)
    {    
        Console.WriteLine("Powered - " + Math.Pow(num1, num2));
    }

    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 25, option 2
Console.Clear();
user = 1;

Console.WriteLine("Task 25-2. Return raised 1st number to the power of 2nd number");

while (user == 1)
{
    int a25 = new Random().Next(1, 5);
    int b25 = new Random().Next(0, 10);
    Console.WriteLine("1st number - " + a25);
    Console.WriteLine("2nd number - " + b25);
    
    pow2numbers2(a25, b25);

    void pow2numbers2(int num1, int num2)
    {
        int result = num1;
        for(int count = 1; count < num2; count++)
        {
            result *= num1;
        }
        Console.WriteLine("Powered - " + result);
    }

    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 25, option 3
Console.Clear();
user = 1;

Console.WriteLine("Task 25-3. Return raised 1st number to the power of 2nd number");

while (user == 1)
{
    int a25 = new Random().Next(1, 5);
    int b25 = new Random().Next(0, 10);
    Console.WriteLine("1st number - " + a25);
    Console.WriteLine("2nd number - " + b25);
    
    Console.WriteLine("Powered - " + Math.Pow(a25, b25));

    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 27
Console.Clear();
user = 1;

Console.WriteLine("Task 27. Return sum of every digit in the number");

while (user == 1)
{
    int num27 = new Random().Next(1, 2000);

    digitsum(num27);

    void digitsum(int number)
    {
        Console.WriteLine("Number - " + number);
        string tempNumber = Convert.ToString(number);
        int result = 0;

        for (int count = 0; count < tempNumber.Length; count++)
        {
            result += Convert.ToInt32(Convert.ToString(tempNumber[count]));
        }
        Console.WriteLine("Sum of digits - " + result);
    }

     Console.WriteLine("Press 1 to repeat task or press 0 for next task");
     user = Convert.ToInt32(Console.ReadLine());
}


//Task 29
Console.Clear();
user = 1;

Console.WriteLine("Task 29. Create and return array with 8 numbers");

while (user == 1)
{
    array8numbers();
        
    void array8numbers()
    {
        int[] array = new int[8];
       
        for (int count = 0; count < 8; count++)
        {
            array[count] = new Random().Next(1, 50);
            Console.WriteLine($"{count+1}) {array[count]}");
        }
        Console.WriteLine("Array - [" + string.Join(", ", array) + "]");
    }

    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");