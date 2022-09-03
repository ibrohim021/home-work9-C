// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

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

for(int i = n; i < m+1; i++)
{
    
    Console.Write($"{i} ");
}
