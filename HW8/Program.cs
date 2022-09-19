//Creates new random matrix
int[,] newRandomMatrix(int rows, int colums, int min, int max) 
{
    int [,] matrix = new int [rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

//Print matrix in console 
void printMatrix(int [,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int user = 0;

//Task 54
Console.Clear();
user = 1;

Console.WriteLine("Task 54. Sort every random matrix row in descending order");
Console.WriteLine();

while (user == 1)
{
    int [,] matrix54 = newRandomMatrix(7,5,-9,10);
    printMatrix(matrix54);
    Console.WriteLine();

    for (int i = 0; i < matrix54.GetLength(0); i++)
    {
        for (int j = 0; j < matrix54.GetLength(1) - 1; j++)
        {
            int maxIndex54 = j;
            for (int k = j + 1 ; k < matrix54.GetLength(1); k++)
            {
                if (matrix54[i,k] > matrix54[i,maxIndex54]) maxIndex54 = k;
            }
            int temp = matrix54 [i, j];
            matrix54[i,j] = matrix54 [i, maxIndex54];
            matrix54 [i, maxIndex54] = temp;
        }
    }

    printMatrix(matrix54);

    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 56
Console.Clear();
user = 1;

Console.WriteLine("Task 56. Return which random matrix row has minimum sum of numbers");
Console.WriteLine();

while (user == 1)
{
    int [,] matrix56 = newRandomMatrix(10,10,-9,10);
    printMatrix(matrix56);
    Console.WriteLine();

    int minSum = int.MaxValue;
    int minSumIndex = new int();
    for (int i = 0; i < matrix56.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < matrix56.GetLength(1); j++)
        {
            tempSum += matrix56[i,j];
        }
        Console.WriteLine($"Row #{i+1} sum - " + tempSum);
        if (tempSum < minSum) 
        {
            minSumIndex = i;
            minSum = tempSum;
        }
    }
    
    Console.WriteLine();
    Console.WriteLine("Minimal sum row - row #" + (minSumIndex + 1));

    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 58
Console.Clear();
user = 1;

Console.WriteLine("Task 58. Return matrix from multiplyig of two random matrix");
Console.WriteLine();

while (user == 1)
{
    int [,] matrix58A = newRandomMatrix(2,2,0,10);
    printMatrix(matrix58A);
    Console.WriteLine();
    int [,] matrix58B = newRandomMatrix(2,2,0,10);
    printMatrix(matrix58B);
    Console.WriteLine();

    if (matrix58A.GetLength(1) == matrix58B.GetLength(0))
    {
        int [,] matrix58new = new int[matrix58A.GetLength(0),matrix58B.GetLength(1)];
        for (int i = 0; i < matrix58A.GetLength(0); i++)
        {
            for (int j = 0; j < matrix58B.GetLength(1); j++)
            {
                for (int k = 0; k < matrix58A.GetLength(1); k++)
                {
                    matrix58new[i,j] += matrix58A[i,k]*matrix58B[k,j];
                }
            }
        }
        printMatrix(matrix58new);
    }
    else Console.WriteLine("Multplying is impossible. " +
    "Number if columns 1st matrix is not equal to number of rows 2nd matrix");
    
    
    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

//Task 60
Console.Clear();
user = 1;

Console.WriteLine( "Task 60. Create 3D array and return arrays of elemens " + 
"line by line adding index of 3D array");
Console.WriteLine();

while (user == 1)
{
    int [,,] array3d60 =    {
                            {{66, 27},{25, 90}},
                            {{34, 26},{41, 55}}
                            };
    for (int i = 0; i < array3d60.GetLength(0); i++)
    {
        for (int j = 0; j < array3d60.GetLength(1); j++)
        {
            for (int k = 0; k < array3d60.GetLength(2); k++)
            {    
                Console.WriteLine(array3d60[i,j,k] + $" - [{i}, {j}, {k}]");
            }
        }
    }
    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}


//Task 62
Console.Clear();
user = 1;

Console.WriteLine("Task 62. Return spirally filled 4*4 matrix of sequential numbers");
Console.WriteLine();

while (user == 1)
{
    Console.WriteLine("Insert quantity of rows/columns for square matrix: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 1)
    {
        int y = x;
        int [,] matrix62 = new int[x, y];
        int numbers = 1;

        for (int i = 0; i < y; i++)
        {
            matrix62[0, i] = numbers;
            numbers++;
        }
        for (int i = 1; i < x; i++)
        {
            matrix62[i, y-1] = numbers;
            numbers++;
        }
        for (int i = y - 2; i >= 0; i--)
        {
            matrix62[x-1,i] = numbers;
            numbers++;
        }
        for (int i = x - 2; i > 0; i--)
        {
            matrix62[i,0] = numbers;
            numbers++; 
        }
        
        int x2 = 1;
        int y2 = 1;
        while(matrix62[x2,y2] == 0)
        {
            while(matrix62[x2,y2] == 0)
            {
                matrix62[x2,y2] = numbers;
                numbers++;
                if (matrix62[x2,y2+1] == 0) y2++;
            }
            x2 += 1;
            while(matrix62[x2, y2] == 0)
            {
                matrix62[x2,y2] = numbers;
                numbers++;
                if (matrix62[x2+1,y2] == 0) x2++;
            }
            y2 -= 1;
            while(matrix62[x2, y2] == 0)
            {
                matrix62[x2,y2] = numbers;
                numbers++;
                if (matrix62[x2,y2 - 1] == 0) y2--;
            }
            x2 -= 1;
            while(matrix62[x2,y2] == 0)
            {
                matrix62[x2, y2] = numbers;
                numbers++;
                if (matrix62[x2 - 1,y2] == 0) x2--;
            }
            y2 += 1;
        }    
        printMatrix(matrix62);
    }
    else Console.WriteLine("Can't creat spiral matrix. Use more rows/columns.");

    Console.WriteLine();
    Console.Write("Press 1 to repeat task or press 0 for next task");
    user = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("No tasks. Homework is over");