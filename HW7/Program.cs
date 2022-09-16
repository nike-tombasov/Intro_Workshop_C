int user = 0;

//Creates new random matrix and print it
int[,] newRandomMatrix(int rows, int colums, int min, int max) 
{
    int [,] matrix = new int [rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max);
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return matrix;
}


//Task 47
Console.Clear();
user = 1;

Console.WriteLine("Task 47. Generate random matrix m*n with random float numbers");
Console.WriteLine();

while (user == 1)
{
    int m = new Random().Next(3, 4);
    int n = new Random().Next(3, 4);

    double [,] matrix = new double [m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble(), 2) 
            + new Random().Next(-9, 10);
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 50
Console.Clear();
user = 1;

Console.WriteLine("Task 50. Return number form matrix by inserted postition "
+ "or show error if it's no such position");
Console.WriteLine();

while (user == 1)
{
    int[,] matrix50 = newRandomMatrix(5, 5, -10, 11);
    Console.Write("Enter row #: ");
    int row50 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter column #: ");
    int column50 = Convert.ToInt32(Console.ReadLine());

    if (row50 > matrix50.GetLength(0) || column50 > matrix50.GetLength(1))
    {
        Console.WriteLine("No such position in matrix");
    }
    else
    {
        Console.WriteLine($"Row {row50} and column {column50}] number: " 
        + matrix50[row50 - 1 , column50 -1 ]);
    }
    
    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 52
Console.Clear();
user = 1;

Console.WriteLine("Task 52. Return every column AVG from random matrix");
Console.WriteLine();

while (user == 1)
{
    int[,] matrix52 = newRandomMatrix(4, 4, 0, 11);

    for (int i = 0; i < matrix52.GetLength(0); i++)
    {
        double tempsum = 0;
        for (int j = 0; j < matrix52.GetLength(1); j++)
        {
            tempsum += matrix52[j,i];
        }
        Console.WriteLine($"AVG column #{i+1}: " + tempsum / matrix52.GetLength(0));
    }
    
    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");