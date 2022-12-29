// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int N = InputNumber("Введите число N: ");
int b = 1;
Number(N,b);
System.Console.WriteLine();


void Number(int n, int b)
{
if (b > n)
{
return;
}
Number(n,b+1);
System.Console.Write($" {b} ");
}

int InputNumber(string str)
{
int number;
string text;
while (true)
{
System.Console.Write(str);
text = Console.ReadLine();
if (int.TryParse(text, out number))
{
break;
}
System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}

