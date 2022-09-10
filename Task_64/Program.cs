// Задача 64: Задайте значения M и N. Напишите программу, которая найдет сумму чисел от M до N.
// M = 1; N = 5. -> 1, 2, 3, 4, 5
// M = 4; N = 8. -> 4, 6, 7, 8

Console.Clear();

Console.Clear();

int Numbers(int m, int n)
{
    int sum = 0;
    if(m > n)
        return sum;
    if(m == n)
        sum += m;
    else
        sum += m;
    return sum + Numbers(m + 1,n);
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int sum = Numbers(m,n);
Console.WriteLine(Numbers(m,n));