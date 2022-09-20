int user = 0;

//Task 64
Console.Clear();
user = 1;

Console.WriteLine("Task 64. Return natural numbers line between two inserted numbers");
Console.WriteLine();

string NaturalNums(int m, int n)
{
    if (m == n) return $"{m} ";
    if (m > n) return $"{m} " + NaturalNums(m - 1, n);
    if (m < n) return $"{m} " + NaturalNums(m + 1, n);
    else return String.Empty;
}

while (user == 1)
{
    Console.Write("Insert your number 1: ");
    int number64_1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert your number 2: ");
    int number64_2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Numbers line - " + NaturalNums(number64_1, number64_2));

    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 66
Console.Clear();
user = 1;

Console.WriteLine("Task 66. Return sum of every number between two inserted numbers");
Console.WriteLine();

int NaturalSum(int m, int n)
{
    if (m > n) return n + NaturalSum(m, n + 1);
    if (m < n) return m + NaturalSum(m + 1, n);
    else return m;
}


while (user == 1)
{
    Console.Write("Insert your number 1: ");
    int number66_1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert your number 2: ");
    int number66_2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Sum - " + NaturalSum(number66_1, number66_2));

    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 68
Console.Clear();
user = 1;

Console.WriteLine("Task 68. Describe Akkerman function with recursion using two positive numbers");
Console.WriteLine();

double fAkkerman(double m, double n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return fAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return fAkkerman(m - 1, fAkkerman(m, n - 1));
    else return 0;
}


while (user == 1)
{
    Console.Write("Insert your number 1: ");
    int number68_1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insert your number 2: ");
    int number68_2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Akkerman method - " + fAkkerman(number68_1, number68_2));

    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");