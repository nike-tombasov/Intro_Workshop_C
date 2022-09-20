int[] newRandomArray(int size, int min, int max) //Creates new random array
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

//Creates new random matrix
int[,] newRandomMatrix(int rows, int colums, int min, int max) 
{
    int [,] matrix = new int [rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max);
            // Console.Write(matrix[i,j] + "\t");
        }
        // Console.WriteLine();
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



// //  Задайте двумерный массив размера m на n, 
// // каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// // Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5

// int m = 5;
// int n = 4;



// int [,] matrix = new int [m, n];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(-20, 21);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine();

// // Задайте двумерный массив. Найдите элементы, 
// // у которых оба индекса чётные, и замените эти элементы на их квадраты.

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             matrix[i,j] = Convert.ToInt32(Math.Pow(matrix[i,j], 2));
//         }
        
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// // Console.WriteLine(Math.Pow(2, 2));

// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.

// int [,] matrix = newRandomMatrix(4, 4, 0, 10); //Creates new matrix
// printMatrix(matrix); //Print matrix in console
// Console.WriteLine();

// int [,] matrixnew = new int[matrix.GetLength(0),matrix.GetLength(1)];

// for (int i = 0; i < matrix.GetLength(1); i++)
// {
//     matrixnew[0,i] = matrix[matrix.GetLength(0)-1,i];
//     matrixnew[matrix.GetLength(0)-1,i] = matrix[0,i];
// }
// printMatrix(matrixnew); //Print matrix in console

// if (matrix.GetLength(0) == matrix.GetLength(1))
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 matrixnew[j,i] = matrix[i,j];
//             }
//         }

//     printMatrix(matrixnew); 
// }
// else Console.WriteLine("Impossible to change rows/columns");

// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


// int [,] matrix = newRandomMatrix(5, 4, 0, 10); //Creates new matrix
// printMatrix(matrix); //Print matrix in console

// int [,] matrixnew = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];

// int min = matrix[0,0];
// int rowMin = 0;
// int columnMin = 0;

// for (int i = 0; i < matrix.GetLength(0); i++) // Searching for MIN 
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (matrix[i,j] < min)
//         {
//             min = matrix[i,j];
//             rowMin = i;
//             columnMin = j;
//         }
//     }
// }

// Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0)-1; i++) // Filling new matrix
// {
//     if (i >= rowMin)
//     {
//         for (int j = 0; j < matrix.GetLength(1)-1; j++)
//         {
//             if (j >= columnMin) matrixnew[i,j] = matrix [i+1,j+1];
//             else                matrixnew[i,j] = matrix [i+1,j];
//         }
//     }
//     else 
//     {
//         for (int j = 0; j < matrix.GetLength(1)-1; j++)
//         {
//             if (j >= columnMin) matrixnew[i,j] = matrix [i,j+1];
//             else                matrixnew[i,j] = matrix [i,j];
//         }
//     }
// }

// printMatrix(matrixnew); //Print matrix in console



//Initialization 
int [,,] array3d = new int[2,2,2];
int [] array = new int[100];

//Filling array with 0-99 numbers
for (int i = 0; i < 100; i++)
{
    array[i] = i;
}

//Filling 3D array
int index = 0;
for (int i = 0; i < array3d.GetLength(0); i++)
{
    index = 0;
    for (int j = 0; j < array3d.GetLength(1); j++)
    {
        index = 0;
        for (int k = 0; k < array3d.GetLength(2); k++)
        {
            index = 0;    
            while(array[index] == 0)
            {    
                index = new Random().Next(10,array.Length); //random 10-99
                if (array[index] != 0)
                {
                    array3d[i,j,k] = array[index];
                    array[index] = 0;
                    index = 1;
                }
            }
        }
    }
}

//Print 3D array
for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {    
                Console.WriteLine(array3d[i,j,k] + $" - [{i}, {j}, {k}]");
            }
        }
    }