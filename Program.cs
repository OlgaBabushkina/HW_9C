/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int N = new Random().Next(1, 10);
Console.WriteLine(N);
NumberDecreasing(N);

void NumberDecreasing(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        NumberDecreasing(n - 1);
    }
}

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M = new Random().Next(0, 10);
int N = new Random().Next(0, 10);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {SumNumbers(M, N)}");

int SumNumbers(int min, int max)
{
    if (min == max)
    {
        return min;
    }
    if (min > max)
    {
        return max + SumNumbers(min, max + 1);
    }
    else
    {
        return min + SumNumbers(min + 1, max);
    }

}

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int m = new Random().Next(1, 4);
int n = new Random().Next(1, 6);
Console.WriteLine($"Значение функции Аккермана при m = {m} и n = {n} равно {Ack(m, n)}");
int Ack(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0)
    {
        return Ack(M - 1, 1);
    }
    else
    {
        return Ack(M - 1, Ack(M, N - 1));
    }
}







