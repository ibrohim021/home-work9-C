// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.Clear();
Console.WriteLine($"Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int m = InputNumbers("Введите n: ");
int n = InputNumbers("Введите m: ");

int functionAkkerman = Ack(n, m);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int n, int m)
{
  if (n == 0) return m + 1;
  else if (m == 0) return Ack(n - 1, 1);
  else return Ack(n - 1, Ack(n, m - 1));
}

