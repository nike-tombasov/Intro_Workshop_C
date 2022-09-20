// задайте значение N. напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N

int naturals (int n)
{
    int m = n;
    if (n != 1) Console.WriteLine(n);
    else Console.WriteLine(naturals(n-1));
    return m;
}

naturals(5); 