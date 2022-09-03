// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введиетчисло N");
if(!int.TryParse(Console.ReadLine()!, out int n))
{
    Console.WriteLine("Введите числа");
}

Console.WriteLine("Введите число M");
if(!int.TryParse(Console.ReadLine()!, out int m))
{
    Console.WriteLine("Введите число");
}

void NumberSum (int n, int m, int sum)
{
    if (n> m) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (n++);
    NumberSum(n, m, sum);
}

NumberSum(n, m, 0);
