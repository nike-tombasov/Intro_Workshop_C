//Initializing and printing input
string[] arrayIn = {"1.", "Some", "Things", "We", "Make", "!", ":-)"};
string[] arrayTemp = new string[arrayIn.Length];
int j = 0;
Console.WriteLine("Input array:");
Console.WriteLine("[{0}]", String.Join(" ", arrayIn));
Console.WriteLine();

//Filtering array (3 symbols or less)
for (int i = 0; i < arrayIn.Length; i++)
{
    if (arrayIn[i].Length <= 3)
    {
        arrayTemp[j] = arrayIn[i];
        j++;
    }
}

//Initializing output array
string[] arrayOut = new string[j+1];

//Clearing array from empty strings and printing output
for (int k = 0; k < j; k++)
{
    arrayOut[k] = arrayTemp[k] ;
}
Console.WriteLine("Filtered array with strings that have 3 symbols or less:");
Console.WriteLine("[{0}]", String.Join(" ", arrayOut));

