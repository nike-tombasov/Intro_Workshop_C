int user = 0;

int[] newRandomArray(int size, int min, int max) //Creates new random array
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

//Task 34
Console.Clear();
user = 1;

Console.WriteLine("Task 34. Count every even number in random 3-digit numbers array");

while (user == 1)
{
    int[] array34 = newRandomArray(10, 100, 1000);
    Console.WriteLine("[{0}]", String.Join(", ", array34));
    Console.WriteLine("Even numbers in array - " + countEvenInArray(array34));
    
    int countEvenInArray (int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count++;
        }
        return count;
    }

    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 36
Console.Clear();
user = 1;

Console.WriteLine("Task 36. Sum odd-positioned numbers in random array");

while (user == 1)
{
    int[] array36 = newRandomArray(10, -20, 21);
    Console.WriteLine("[{0}]", String.Join(", ", array36));
    Console.WriteLine("Odd position sum - " + sumOddArray(array36));

    int sumOddArray(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }

    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 38
Console.Clear();
user = 1;

Console.WriteLine("Task 38. Return subtraction between max and min of real numbered array");

while (user == 1)
{
    int[] array38 = newRandomArray(10, -20, 21);
    Console.WriteLine("[{0}]", String.Join(", ", array38));
    Console.WriteLine("Max-min subtraction - " + minmaxarraysubtract(array38));

    int minmaxarraysubtract(int[] array)
    {
        int min = 0;
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }
        int result = max - min;
        return result;
    }

    Console.WriteLine("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");